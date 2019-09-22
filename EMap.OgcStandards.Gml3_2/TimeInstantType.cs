﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeInstant", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeInstantType : AbstractTimeGeometricPrimitiveType {
        
        private TimePositionType timePositionField;
        
        
        public TimePositionType timePosition {
            get {
                return this.timePositionField;
            }
            set {
                this.timePositionField = value;
            }
        }
    }
}
