﻿namespace EMap.OgcStandards.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/fes/2.0")]
    public partial class ExtensionOperatorType {
        
        private System.Xml.XmlQualifiedName nameField;
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.Xml.XmlQualifiedName name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}
