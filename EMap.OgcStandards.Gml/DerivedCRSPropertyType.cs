﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("derivedCRSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DerivedCRSPropertyType {
        
        private DerivedCRSType derivedCRSField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public DerivedCRSType DerivedCRS {
            get {
                return this.derivedCRSField;
            }
            set {
                this.derivedCRSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
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
