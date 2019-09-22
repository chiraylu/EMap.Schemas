﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("generalConversionRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeneralConversionRefType {
        
        private AbstractGeneralConversionType _GeneralConversionField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractGeneralConversionType _GeneralConversion {
            get {
                return this._GeneralConversionField;
            }
            set {
                this._GeneralConversionField = value;
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
