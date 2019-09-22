﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeTopologyComplex", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public abstract partial class TimeTopologyComplexType : AbstractTimeComplexType {
        
        private TimeTopologyPrimitivePropertyType[] primitiveField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("primitive")]
        public TimeTopologyPrimitivePropertyType[] primitive {
            get {
                return this.primitiveField;
            }
            set {
                this.primitiveField = value;
            }
        }
    }
}
