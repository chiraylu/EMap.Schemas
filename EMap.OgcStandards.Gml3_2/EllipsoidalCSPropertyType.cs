﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("ellipsoidalCS", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class EllipsoidalCSPropertyType {
        
        private EllipsoidalCSType ellipsoidalCSField;
        
        private string nilReasonField;
        
        private string remoteSchemaField;
        
        
        public EllipsoidalCSType EllipsoidalCS {
            get {
                return this.ellipsoidalCSField;
            }
            set {
                this.ellipsoidalCSField = value;
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
