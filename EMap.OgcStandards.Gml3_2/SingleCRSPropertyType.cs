﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("componentReferenceSystem", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class SingleCRSPropertyType {
        
        private AbstractCRSType abstractSingleCRSField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        
        public AbstractCRSType AbstractSingleCRS {
            get {
                return this.abstractSingleCRSField;
            }
            set {
                this.abstractSingleCRSField = value;
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
