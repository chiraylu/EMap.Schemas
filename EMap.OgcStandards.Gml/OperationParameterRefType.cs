﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("valueOfParameter", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class OperationParameterRefType {
        
        private OperationParameterType operationParameterField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public OperationParameterType OperationParameter {
            get {
                return this.operationParameterField;
            }
            set {
                this.operationParameterField = value;
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
