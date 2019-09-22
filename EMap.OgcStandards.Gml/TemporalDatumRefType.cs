﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("temporalDatumRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TemporalDatumRefType {
        
        private TemporalDatumType temporalDatumField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public TemporalDatumType TemporalDatum {
            get {
                return this.temporalDatumField;
            }
            set {
                this.temporalDatumField = value;
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
