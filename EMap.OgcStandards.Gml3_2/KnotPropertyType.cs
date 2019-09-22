﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class KnotPropertyType {
        
        private KnotType knotField;
        
        
        public KnotType Knot {
            get {
                return this.knotField;
            }
            set {
                this.knotField = value;
            }
        }
    }
}
