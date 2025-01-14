﻿namespace EMap.OgcStandards.Swe2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/swe/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Text", Namespace="http://www.opengis.net/swe/2.0", IsNullable=false)]
    public partial class TextType : AbstractSimpleComponentType {
        
        private AllowedTokensPropertyType constraintField;
        
        private string valueField;
        
        
        public AllowedTokensPropertyType constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
