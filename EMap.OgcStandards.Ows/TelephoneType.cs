﻿namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows")]
    public partial class TelephoneType {
        
        private string[] voiceField;
        
        private string[] facsimileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Voice")]
        public string[] Voice {
            get {
                return this.voiceField;
            }
            set {
                this.voiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Facsimile")]
        public string[] Facsimile {
            get {
                return this.facsimileField;
            }
            set {
                this.facsimileField = value;
            }
        }
    }
}
