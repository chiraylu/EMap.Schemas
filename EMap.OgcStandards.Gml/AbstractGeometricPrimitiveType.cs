﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractGeometricPrimitiveType : AbstractGeometryType {
    }
}
