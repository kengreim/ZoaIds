﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false, ElementName="response")]
public partial class MetarApiXmlResponse {
    
    private int request_indexField;
    
    private data_source data_sourceField;
    
    private request requestField;
    
    private errors errorsField;
    
    private warnings warningsField;
    
    private int time_taken_msField;
    
    private data dataField;
    
    private string versionField;
    
    public MetarApiXmlResponse() {
        this.versionField = "1.2";
    }
    
    /// <remarks/>
    public int request_index {
        get {
            return this.request_indexField;
        }
        set {
            this.request_indexField = value;
        }
    }
    
    /// <remarks/>
    public data_source data_source {
        get {
            return this.data_sourceField;
        }
        set {
            this.data_sourceField = value;
        }
    }
    
    /// <remarks/>
    public request request {
        get {
            return this.requestField;
        }
        set {
            this.requestField = value;
        }
    }
    
    /// <remarks/>
    public errors errors {
        get {
            return this.errorsField;
        }
        set {
            this.errorsField = value;
        }
    }
    
    /// <remarks/>
    public warnings warnings {
        get {
            return this.warningsField;
        }
        set {
            this.warningsField = value;
        }
    }
    
    /// <remarks/>
    public int time_taken_ms {
        get {
            return this.time_taken_msField;
        }
        set {
            this.time_taken_msField = value;
        }
    }
    
    /// <remarks/>
    public data data {
        get {
            return this.dataField;
        }
        set {
            this.dataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("1.2")]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class data_source {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class request {
    
    private string typeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class errors {
    
    private string errorField;
    
    /// <remarks/>
    public string error {
        get {
            return this.errorField;
        }
        set {
            this.errorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class warnings {
    
    private string warningField;
    
    /// <remarks/>
    public string warning {
        get {
            return this.warningField;
        }
        set {
            this.warningField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class data {
    
    private METAR[] mETARField;
    
    private int num_resultsField;
    
    private bool num_resultsFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("METAR")]
    public METAR[] METAR {
        get {
            return this.mETARField;
        }
        set {
            this.mETARField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int num_results {
        get {
            return this.num_resultsField;
        }
        set {
            this.num_resultsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool num_resultsSpecified {
        get {
            return this.num_resultsFieldSpecified;
        }
        set {
            this.num_resultsFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class METAR {
    
    private string raw_textField;
    
    private string station_idField;
    
    private string observation_timeField;
    
    private float latitudeField;
    
    private bool latitudeFieldSpecified;
    
    private float longitudeField;
    
    private bool longitudeFieldSpecified;
    
    private float temp_cField;
    
    private bool temp_cFieldSpecified;
    
    private float dewpoint_cField;
    
    private bool dewpoint_cFieldSpecified;
    
    private int wind_dir_degreesField;
    
    private bool wind_dir_degreesFieldSpecified;
    
    private int wind_speed_ktField;
    
    private bool wind_speed_ktFieldSpecified;
    
    private int wind_gust_ktField;
    
    private bool wind_gust_ktFieldSpecified;
    
    private float visibility_statute_miField;
    
    private bool visibility_statute_miFieldSpecified;
    
    private float altim_in_hgField;
    
    private bool altim_in_hgFieldSpecified;
    
    private float sea_level_pressure_mbField;
    
    private bool sea_level_pressure_mbFieldSpecified;
    
    private quality_control_flags quality_control_flagsField;
    
    private string wx_stringField;
    
    private sky_condition[] sky_conditionField;
    
    private string flight_categoryField;
    
    private float three_hr_pressure_tendency_mbField;
    
    private bool three_hr_pressure_tendency_mbFieldSpecified;
    
    private float maxT_cField;
    
    private bool maxT_cFieldSpecified;
    
    private float minT_cField;
    
    private bool minT_cFieldSpecified;
    
    private float maxT24hr_cField;
    
    private bool maxT24hr_cFieldSpecified;
    
    private float minT24hr_cField;
    
    private bool minT24hr_cFieldSpecified;
    
    private float precip_inField;
    
    private bool precip_inFieldSpecified;
    
    private float pcp3hr_inField;
    
    private bool pcp3hr_inFieldSpecified;
    
    private float pcp6hr_inField;
    
    private bool pcp6hr_inFieldSpecified;
    
    private float pcp24hr_inField;
    
    private bool pcp24hr_inFieldSpecified;
    
    private float snow_inField;
    
    private bool snow_inFieldSpecified;
    
    private int vert_vis_ftField;
    
    private bool vert_vis_ftFieldSpecified;
    
    private string metar_typeField;
    
    private float elevation_mField;
    
    private bool elevation_mFieldSpecified;
    
    /// <remarks/>
    public string raw_text {
        get {
            return this.raw_textField;
        }
        set {
            this.raw_textField = value;
        }
    }
    
    /// <remarks/>
    public string station_id {
        get {
            return this.station_idField;
        }
        set {
            this.station_idField = value;
        }
    }
    
    /// <remarks/>
    public string observation_time {
        get {
            return this.observation_timeField;
        }
        set {
            this.observation_timeField = value;
        }
    }
    
    /// <remarks/>
    public float latitude {
        get {
            return this.latitudeField;
        }
        set {
            this.latitudeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool latitudeSpecified {
        get {
            return this.latitudeFieldSpecified;
        }
        set {
            this.latitudeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float longitude {
        get {
            return this.longitudeField;
        }
        set {
            this.longitudeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool longitudeSpecified {
        get {
            return this.longitudeFieldSpecified;
        }
        set {
            this.longitudeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float temp_c {
        get {
            return this.temp_cField;
        }
        set {
            this.temp_cField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool temp_cSpecified {
        get {
            return this.temp_cFieldSpecified;
        }
        set {
            this.temp_cFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float dewpoint_c {
        get {
            return this.dewpoint_cField;
        }
        set {
            this.dewpoint_cField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dewpoint_cSpecified {
        get {
            return this.dewpoint_cFieldSpecified;
        }
        set {
            this.dewpoint_cFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public int wind_dir_degrees {
        get {
            return this.wind_dir_degreesField;
        }
        set {
            this.wind_dir_degreesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool wind_dir_degreesSpecified {
        get {
            return this.wind_dir_degreesFieldSpecified;
        }
        set {
            this.wind_dir_degreesFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public int wind_speed_kt {
        get {
            return this.wind_speed_ktField;
        }
        set {
            this.wind_speed_ktField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool wind_speed_ktSpecified {
        get {
            return this.wind_speed_ktFieldSpecified;
        }
        set {
            this.wind_speed_ktFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public int wind_gust_kt {
        get {
            return this.wind_gust_ktField;
        }
        set {
            this.wind_gust_ktField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool wind_gust_ktSpecified {
        get {
            return this.wind_gust_ktFieldSpecified;
        }
        set {
            this.wind_gust_ktFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float visibility_statute_mi {
        get {
            return this.visibility_statute_miField;
        }
        set {
            this.visibility_statute_miField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool visibility_statute_miSpecified {
        get {
            return this.visibility_statute_miFieldSpecified;
        }
        set {
            this.visibility_statute_miFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float altim_in_hg {
        get {
            return this.altim_in_hgField;
        }
        set {
            this.altim_in_hgField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool altim_in_hgSpecified {
        get {
            return this.altim_in_hgFieldSpecified;
        }
        set {
            this.altim_in_hgFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float sea_level_pressure_mb {
        get {
            return this.sea_level_pressure_mbField;
        }
        set {
            this.sea_level_pressure_mbField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sea_level_pressure_mbSpecified {
        get {
            return this.sea_level_pressure_mbFieldSpecified;
        }
        set {
            this.sea_level_pressure_mbFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public quality_control_flags quality_control_flags {
        get {
            return this.quality_control_flagsField;
        }
        set {
            this.quality_control_flagsField = value;
        }
    }
    
    /// <remarks/>
    public string wx_string {
        get {
            return this.wx_stringField;
        }
        set {
            this.wx_stringField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sky_condition")]
    public sky_condition[] sky_condition {
        get {
            return this.sky_conditionField;
        }
        set {
            this.sky_conditionField = value;
        }
    }
    
    /// <remarks/>
    public string flight_category {
        get {
            return this.flight_categoryField;
        }
        set {
            this.flight_categoryField = value;
        }
    }
    
    /// <remarks/>
    public float three_hr_pressure_tendency_mb {
        get {
            return this.three_hr_pressure_tendency_mbField;
        }
        set {
            this.three_hr_pressure_tendency_mbField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool three_hr_pressure_tendency_mbSpecified {
        get {
            return this.three_hr_pressure_tendency_mbFieldSpecified;
        }
        set {
            this.three_hr_pressure_tendency_mbFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float maxT_c {
        get {
            return this.maxT_cField;
        }
        set {
            this.maxT_cField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxT_cSpecified {
        get {
            return this.maxT_cFieldSpecified;
        }
        set {
            this.maxT_cFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float minT_c {
        get {
            return this.minT_cField;
        }
        set {
            this.minT_cField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool minT_cSpecified {
        get {
            return this.minT_cFieldSpecified;
        }
        set {
            this.minT_cFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float maxT24hr_c {
        get {
            return this.maxT24hr_cField;
        }
        set {
            this.maxT24hr_cField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxT24hr_cSpecified {
        get {
            return this.maxT24hr_cFieldSpecified;
        }
        set {
            this.maxT24hr_cFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float minT24hr_c {
        get {
            return this.minT24hr_cField;
        }
        set {
            this.minT24hr_cField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool minT24hr_cSpecified {
        get {
            return this.minT24hr_cFieldSpecified;
        }
        set {
            this.minT24hr_cFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float precip_in {
        get {
            return this.precip_inField;
        }
        set {
            this.precip_inField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool precip_inSpecified {
        get {
            return this.precip_inFieldSpecified;
        }
        set {
            this.precip_inFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float pcp3hr_in {
        get {
            return this.pcp3hr_inField;
        }
        set {
            this.pcp3hr_inField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool pcp3hr_inSpecified {
        get {
            return this.pcp3hr_inFieldSpecified;
        }
        set {
            this.pcp3hr_inFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float pcp6hr_in {
        get {
            return this.pcp6hr_inField;
        }
        set {
            this.pcp6hr_inField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool pcp6hr_inSpecified {
        get {
            return this.pcp6hr_inFieldSpecified;
        }
        set {
            this.pcp6hr_inFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float pcp24hr_in {
        get {
            return this.pcp24hr_inField;
        }
        set {
            this.pcp24hr_inField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool pcp24hr_inSpecified {
        get {
            return this.pcp24hr_inFieldSpecified;
        }
        set {
            this.pcp24hr_inFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public float snow_in {
        get {
            return this.snow_inField;
        }
        set {
            this.snow_inField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool snow_inSpecified {
        get {
            return this.snow_inFieldSpecified;
        }
        set {
            this.snow_inFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public int vert_vis_ft {
        get {
            return this.vert_vis_ftField;
        }
        set {
            this.vert_vis_ftField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vert_vis_ftSpecified {
        get {
            return this.vert_vis_ftFieldSpecified;
        }
        set {
            this.vert_vis_ftFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string metar_type {
        get {
            return this.metar_typeField;
        }
        set {
            this.metar_typeField = value;
        }
    }
    
    /// <remarks/>
    public float elevation_m {
        get {
            return this.elevation_mField;
        }
        set {
            this.elevation_mField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool elevation_mSpecified {
        get {
            return this.elevation_mFieldSpecified;
        }
        set {
            this.elevation_mFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class quality_control_flags {
    
    private string correctedField;
    
    private string autoField;
    
    private string auto_stationField;
    
    private string maintenance_indicator_onField;
    
    private string no_signalField;
    
    private string lightning_sensor_offField;
    
    private string freezing_rain_sensor_offField;
    
    private string present_weather_sensor_offField;
    
    /// <remarks/>
    public string corrected {
        get {
            return this.correctedField;
        }
        set {
            this.correctedField = value;
        }
    }
    
    /// <remarks/>
    public string auto {
        get {
            return this.autoField;
        }
        set {
            this.autoField = value;
        }
    }
    
    /// <remarks/>
    public string auto_station {
        get {
            return this.auto_stationField;
        }
        set {
            this.auto_stationField = value;
        }
    }
    
    /// <remarks/>
    public string maintenance_indicator_on {
        get {
            return this.maintenance_indicator_onField;
        }
        set {
            this.maintenance_indicator_onField = value;
        }
    }
    
    /// <remarks/>
    public string no_signal {
        get {
            return this.no_signalField;
        }
        set {
            this.no_signalField = value;
        }
    }
    
    /// <remarks/>
    public string lightning_sensor_off {
        get {
            return this.lightning_sensor_offField;
        }
        set {
            this.lightning_sensor_offField = value;
        }
    }
    
    /// <remarks/>
    public string freezing_rain_sensor_off {
        get {
            return this.freezing_rain_sensor_offField;
        }
        set {
            this.freezing_rain_sensor_offField = value;
        }
    }
    
    /// <remarks/>
    public string present_weather_sensor_off {
        get {
            return this.present_weather_sensor_offField;
        }
        set {
            this.present_weather_sensor_offField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class sky_condition {
    
    private string sky_coverField;
    
    private int cloud_base_ft_aglField;
    
    private bool cloud_base_ft_aglFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sky_cover {
        get {
            return this.sky_coverField;
        }
        set {
            this.sky_coverField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int cloud_base_ft_agl {
        get {
            return this.cloud_base_ft_aglField;
        }
        set {
            this.cloud_base_ft_aglField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cloud_base_ft_aglSpecified {
        get {
            return this.cloud_base_ft_aglFieldSpecified;
        }
        set {
            this.cloud_base_ft_aglFieldSpecified = value;
        }
    }
}