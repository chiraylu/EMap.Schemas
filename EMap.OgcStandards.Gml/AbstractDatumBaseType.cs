﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodeticDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemporalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VerticalDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageDatumType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EngineeringDatumType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractDatumBaseType : DefinitionType {
    }
}
