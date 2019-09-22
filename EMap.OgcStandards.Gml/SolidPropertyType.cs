﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("solidProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class SolidPropertyType {
        
        private AbstractSolidType _SolidField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractSolidType _Solid {
            get {
                return this._SolidField;
            }
            set {
                this._SolidField = value;
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
