﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("engineeringCRSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class EngineeringCRSRefType {
        
        private EngineeringCRSType engineeringCRSField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public EngineeringCRSType EngineeringCRS {
            get {
                return this.engineeringCRSField;
            }
            set {
                this.engineeringCRSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="anyURI")]
        public string remoteSchema {
            get {
                return this.remoteSchemaField;
            }
            set {
                this.remoteSchemaField = value;
            }
        }
    }
}
