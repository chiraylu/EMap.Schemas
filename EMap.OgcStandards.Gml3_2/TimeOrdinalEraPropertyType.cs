﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TimeOrdinalEraPropertyType {
        
        private TimeOrdinalEraType timeOrdinalEraField;
        
        private bool ownsField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        public TimeOrdinalEraPropertyType() {
            this.ownsField = false;
        }
        
        
        public TimeOrdinalEraType TimeOrdinalEra {
            get {
                return this.timeOrdinalEraField;
            }
            set {
                this.timeOrdinalEraField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns {
            get {
                return this.ownsField;
            }
            set {
                this.ownsField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
        
        
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
