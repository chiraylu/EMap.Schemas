﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeGeometricPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePeriodType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractTimePrimitiveType : AbstractTimeObjectType {
        
        private RelatedTimeType[] relatedTimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relatedTime")]
        public RelatedTimeType[] relatedTime {
            get {
                return this.relatedTimeField;
            }
            set {
                this.relatedTimeField = value;
            }
        }
    }
}
