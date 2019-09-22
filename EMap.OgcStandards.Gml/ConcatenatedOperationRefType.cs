﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("concatenatedOperationRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ConcatenatedOperationRefType {
        
        private ConcatenatedOperationType concatenatedOperationField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public ConcatenatedOperationType ConcatenatedOperation {
            get {
                return this.concatenatedOperationField;
            }
            set {
                this.concatenatedOperationField = value;
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
