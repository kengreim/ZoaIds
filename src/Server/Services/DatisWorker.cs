using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using ZoaIds.Server.Data;
using ZoaIds.Shared.Models;
using ZoaIds.Shared.ExternalDataModels;

namespace ZoaIds.Server.Services;

public class DatisWorker : BackgroundService
{
    private readonly ILogger<DatisWorker> _logger;
    private readonly IDbContextFactory<ZoaIdsContext> _contextFactory;
    private readonly HttpClient _httpClient;
    private int _delaySeconds;

    public DatisWorker(ILogger<DatisWorker> logger, IDbContextFactory<ZoaIdsContext> contextFactory, HttpClient httpClient)
    {
        _logger = logger;
        _contextFactory = contextFactory;
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(Constants.Urls.ClowdDatisApiEndpoint);
        _delaySeconds = Constants.DatisRefreshDelaySeconds;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(10 * 1000, stoppingToken);
        bool firstLoop = true;

        while (!stoppingToken.IsCancellationRequested)
        {
            // Delay at beginning of the loop, but skip if first time through the loop
            if (!firstLoop)
            {
                _logger.LogInformation("Pausing D-ATIS Worker for {time} seconds", _delaySeconds);
                await Task.Delay(_delaySeconds * 1000, stoppingToken);
            }
            firstLoop = false;

            // Attempt to fetch the D-ATIS JSON file. If we have an error, retry in 1 second
            _logger.LogInformation("Fetching D-ATIS data at: {time}", DateTime.UtcNow);
            Stream stream;
            try
            {
                stream = await _httpClient.GetStreamAsync("all", stoppingToken);
                _logger.LogInformation("Successfully fetched D-ATIS data");
            }
            catch (Exception ex)
            {
                _logger.LogError("Error fetching D-ATIS data: {error}", ex.ToString());
                _delaySeconds = 1;
                break;
            }

            // Deserialize JSON and dispose stream now that we're done with it
            var apiAtisList = await JsonSerializer.DeserializeAsync<List<ClowdApiDatis>>(stream, cancellationToken: stoppingToken);
            stream.Dispose();

            // Open DB and create a dictionary of existing D-ATIS
            using var db = await _contextFactory.CreateDbContextAsync(stoppingToken);
            var existingAtisDict = await db.Atises.AsNoTracking().ToDictionaryAsync(a => a.UniqueId, a => a, stoppingToken);

            // Try to parse each new D-ATIS and determine which are new airports, which are updates, annd which are neither
            var updatedAtisDict = new Dictionary<string, Atis>();
            var newAtisDict = new Dictionary<string, Atis>();
            foreach (var atis in apiAtisList)
            {
                try
                {
                    var fetchedAtis = Atis.ParseFromClowdAtis(atis);
                    var isNewAirport = !existingAtisDict.ContainsKey(fetchedAtis.UniqueId);
                    var isNewLetter = !isNewAirport && existingAtisDict[fetchedAtis.UniqueId].InfoLetter != fetchedAtis.InfoLetter;

                    if (isNewAirport)
                    {
                        newAtisDict.Add(fetchedAtis.UniqueId, fetchedAtis);
                    }
                    else if (isNewLetter)
                    {
                        updatedAtisDict.Add(fetchedAtis.UniqueId, fetchedAtis);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError("Error parsing D-ATIS for {id}: {raw}: {exception}", atis.Airport, atis.Datis, ex.ToString());
                }
            }

            try
            {
                // Add ATISes for any new airports
                await db.Atises.AddRangeAsync(newAtisDict.Values, stoppingToken);
                await db.SaveChangesAsync(stoppingToken);
                _logger.LogInformation("Added {n} new Airports D-ATIS", newAtisDict.Keys.Count);

                // Execute single delete to get rid of all ATISes that need to be updated
                var updatedKeys = updatedAtisDict.Keys.ToList();
                var numDeleted = await db.Atises
                    .Where(a => updatedKeys.Contains(a.UniqueId))
                    .ExecuteDeleteAsync(stoppingToken);
                _logger.LogInformation("Deleted {n} D-ATIS to be updated", numDeleted);

                // Add the updated ATISes
                await db.Atises.AddRangeAsync(updatedAtisDict.Values, stoppingToken);
                await db.SaveChangesAsync(stoppingToken);
                _logger.LogInformation("Added {n} updated D-ATIS", updatedAtisDict.Keys.Count);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error writing D-ATIS to database: {error}", ex.ToString());
            }
        }
    }
}
