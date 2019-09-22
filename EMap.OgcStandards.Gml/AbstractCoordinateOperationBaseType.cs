﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCoordinateOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralTransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeneralConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassThroughOperationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcatenatedOperationType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractCoordinateOperationBaseType : DefinitionType {
    }
}
