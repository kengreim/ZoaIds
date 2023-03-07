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
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TafApiXmlResponse {
    
    private int request_indexField;
    
    private data_source data_sourceField;
    
    private request requestField;
    
    private errors errorsField;
    
    private warnings warningsField;
    
    private int time_taken_msField;
    
    private data dataField;
    
    private string versionField;
    
    public TafApiXmlResponse() {
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

public partial class data {
    
    private TAF[] tAFField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TAF")]
    public TAF[] TAF {
        get {
            return this.tAFField;
        }
        set {
            this.tAFField = value;
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
public partial class TAF {
    
    private string raw_textField;
    
    private string station_idField;
    
    private string issue_timeField;
    
    private string bulletin_timeField;
    
    private string valid_time_fromField;
    
    private string valid_time_toField;
    
    private string remarksField;
    
    private float latitudeField;
    
    private bool latitudeFieldSpecified;
    
    private float longitudeField;
    
    private bool longitudeFieldSpecified;
    
    private float elevation_mField;
    
    private bool elevation_mFieldSpecified;
    
    private forecast[] forecastField;
    
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
    public string issue_time {
        get {
            return this.issue_timeField;
        }
        set {
            this.issue_timeField = value;
        }
    }
    
    /// <remarks/>
    public string bulletin_time {
        get {
            return this.bulletin_timeField;
        }
        set {
            this.bulletin_timeField = value;
        }
    }
    
    /// <remarks/>
    public string valid_time_from {
        get {
            return this.valid_time_fromField;
        }
        set {
            this.valid_time_fromField = value;
        }
    }
    
    /// <remarks/>
    public string valid_time_to {
        get {
            return this.valid_time_toField;
        }
        set {
            this.valid_time_toField = value;
        }
    }
    
    /// <remarks/>
    public string remarks {
        get {
            return this.remarksField;
        }
        set {
            this.remarksField = value;
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("forecast")]
    public forecast[] forecast {
        get {
            return this.forecastField;
        }
        set {
            this.forecastField = value;
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
public partial class forecast {
    
    private string fcst_time_fromField;
    
    private string fcst_time_toField;
    
    private string change_indicatorField;
    
    private string time_becomingField;
    
    private int probabilityField;
    
    private bool probabilityFieldSpecified;
    
    private short wind_dir_degreesField;
    
    private bool wind_dir_degreesFieldSpecified;
    
    private int wind_speed_ktField;
    
    private bool wind_speed_ktFieldSpecified;
    
    private int wind_gust_ktField;
    
    private bool wind_gust_ktFieldSpecified;
    
    private short wind_shear_hgt_ft_aglField;
    
    private bool wind_shear_hgt_ft_aglFieldSpecified;
    
    private short wind_shear_dir_degreesField;
    
    private bool wind_shear_dir_degreesFieldSpecified;
    
    private int wind_shear_speed_ktField;
    
    private bool wind_shear_speed_ktFieldSpecified;
    
    private float visibility_statute_miField;
    
    private bool visibility_statute_miFieldSpecified;
    
    private float altim_in_hgField;
    
    private bool altim_in_hgFieldSpecified;
    
    private short vert_vis_ftField;
    
    private bool vert_vis_ftFieldSpecified;
    
    private string wx_stringField;
    
    private string not_decodedField;
    
    private sky_condition[] sky_conditionField;
    
    private turbulence_condition[] turbulence_conditionField;
    
    private icing_condition[] icing_conditionField;
    
    private temperature[] temperatureField;
    
    /// <remarks/>
    public string fcst_time_from {
        get {
            return this.fcst_time_fromField;
        }
        set {
            this.fcst_time_fromField = value;
        }
    }
    
    /// <remarks/>
    public string fcst_time_to {
        get {
            return this.fcst_time_toField;
        }
        set {
            this.fcst_time_toField = value;
        }
    }
    
    /// <remarks/>
    public string change_indicator {
        get {
            return this.change_indicatorField;
        }
        set {
            this.change_indicatorField = value;
        }
    }
    
    /// <remarks/>
    public string time_becoming {
        get {
            return this.time_becomingField;
        }
        set {
            this.time_becomingField = value;
        }
    }
    
    /// <remarks/>
    public int probability {
        get {
            return this.probabilityField;
        }
        set {
            this.probabilityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool probabilitySpecified {
        get {
            return this.probabilityFieldSpecified;
        }
        set {
            this.probabilityFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public short wind_dir_degrees {
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
    public short wind_shear_hgt_ft_agl {
        get {
            return this.wind_shear_hgt_ft_aglField;
        }
        set {
            this.wind_shear_hgt_ft_aglField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool wind_shear_hgt_ft_aglSpecified {
        get {
            return this.wind_shear_hgt_ft_aglFieldSpecified;
        }
        set {
            this.wind_shear_hgt_ft_aglFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public short wind_shear_dir_degrees {
        get {
            return this.wind_shear_dir_degreesField;
        }
        set {
            this.wind_shear_dir_degreesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool wind_shear_dir_degreesSpecified {
        get {
            return this.wind_shear_dir_degreesFieldSpecified;
        }
        set {
            this.wind_shear_dir_degreesFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public int wind_shear_speed_kt {
        get {
            return this.wind_shear_speed_ktField;
        }
        set {
            this.wind_shear_speed_ktField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool wind_shear_speed_ktSpecified {
        get {
            return this.wind_shear_speed_ktFieldSpecified;
        }
        set {
            this.wind_shear_speed_ktFieldSpecified = value;
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
    public short vert_vis_ft {
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
    public string wx_string {
        get {
            return this.wx_stringField;
        }
        set {
            this.wx_stringField = value;
        }
    }
    
    /// <remarks/>
    public string not_decoded {
        get {
            return this.not_decodedField;
        }
        set {
            this.not_decodedField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("turbulence_condition")]
    public turbulence_condition[] turbulence_condition {
        get {
            return this.turbulence_conditionField;
        }
        set {
            this.turbulence_conditionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("icing_condition")]
    public icing_condition[] icing_condition {
        get {
            return this.icing_conditionField;
        }
        set {
            this.icing_conditionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("temperature")]
    public temperature[] temperature {
        get {
            return this.temperatureField;
        }
        set {
            this.temperatureField = value;
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
public partial class turbulence_condition {
    
    private string turbulence_intensityField;
    
    private int turbulence_min_alt_ft_aglField;
    
    private bool turbulence_min_alt_ft_aglFieldSpecified;
    
    private int turbulence_max_alt_ft_aglField;
    
    private bool turbulence_max_alt_ft_aglFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string turbulence_intensity {
        get {
            return this.turbulence_intensityField;
        }
        set {
            this.turbulence_intensityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int turbulence_min_alt_ft_agl {
        get {
            return this.turbulence_min_alt_ft_aglField;
        }
        set {
            this.turbulence_min_alt_ft_aglField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool turbulence_min_alt_ft_aglSpecified {
        get {
            return this.turbulence_min_alt_ft_aglFieldSpecified;
        }
        set {
            this.turbulence_min_alt_ft_aglFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int turbulence_max_alt_ft_agl {
        get {
            return this.turbulence_max_alt_ft_aglField;
        }
        set {
            this.turbulence_max_alt_ft_aglField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool turbulence_max_alt_ft_aglSpecified {
        get {
            return this.turbulence_max_alt_ft_aglFieldSpecified;
        }
        set {
            this.turbulence_max_alt_ft_aglFieldSpecified = value;
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
public partial class icing_condition {
    
    private string icing_intensityField;
    
    private int icing_min_alt_ft_aglField;
    
    private bool icing_min_alt_ft_aglFieldSpecified;
    
    private int icing_max_alt_ft_aglField;
    
    private bool icing_max_alt_ft_aglFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string icing_intensity {
        get {
            return this.icing_intensityField;
        }
        set {
            this.icing_intensityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int icing_min_alt_ft_agl {
        get {
            return this.icing_min_alt_ft_aglField;
        }
        set {
            this.icing_min_alt_ft_aglField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool icing_min_alt_ft_aglSpecified {
        get {
            return this.icing_min_alt_ft_aglFieldSpecified;
        }
        set {
            this.icing_min_alt_ft_aglFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int icing_max_alt_ft_agl {
        get {
            return this.icing_max_alt_ft_aglField;
        }
        set {
            this.icing_max_alt_ft_aglField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool icing_max_alt_ft_aglSpecified {
        get {
            return this.icing_max_alt_ft_aglFieldSpecified;
        }
        set {
            this.icing_max_alt_ft_aglFieldSpecified = value;
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
public partial class temperature {
    
    private string valid_timeField;
    
    private float sfc_temp_cField;
    
    private bool sfc_temp_cFieldSpecified;
    
    private string max_temp_cField;
    
    private string min_temp_cField;
    
    /// <remarks/>
    public string valid_time {
        get {
            return this.valid_timeField;
        }
        set {
            this.valid_timeField = value;
        }
    }
    
    /// <remarks/>
    public float sfc_temp_c {
        get {
            return this.sfc_temp_cField;
        }
        set {
            this.sfc_temp_cField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sfc_temp_cSpecified {
        get {
            return this.sfc_temp_cFieldSpecified;
        }
        set {
            this.sfc_temp_cFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string max_temp_c {
        get {
            return this.max_temp_cField;
        }
        set {
            this.max_temp_cField = value;
        }
    }
    
    /// <remarks/>
    public string min_temp_c {
        get {
            return this.min_temp_cField;
        }
        set {
            this.min_temp_cField = value;
        }
    }
}
