﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("engineeringDatumRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class EngineeringDatumRefType {
        
        private EngineeringDatumType engineeringDatumField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public EngineeringDatumType EngineeringDatum {
            get {
                return this.engineeringDatumField;
            }
            set {
                this.engineeringDatumField = value;
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
