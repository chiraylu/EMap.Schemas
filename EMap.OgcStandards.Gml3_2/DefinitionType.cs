﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnitDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifiedObjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCRSType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("Definition", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class DefinitionType : DefinitionBaseType {
        
        private string remarksField;
        
        
        public string remarks {
            get {
                return this.remarksField;
            }
            set {
                this.remarksField = value;
            }
        }
    }
}