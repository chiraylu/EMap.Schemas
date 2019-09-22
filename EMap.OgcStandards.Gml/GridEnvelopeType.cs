﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class GridEnvelopeType {
        
        private string lowField;
        
        private string highField;
        
        /// <remarks/>
        public string low {
            get {
                return this.lowField;
            }
            set {
                this.lowField = value;
            }
        }
        
        /// <remarks/>
        public string high {
            get {
                return this.highField;
            }
            set {
                this.highField = value;
            }
        }
    }
}
