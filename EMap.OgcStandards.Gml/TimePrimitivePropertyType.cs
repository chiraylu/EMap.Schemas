﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedTimeType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("validTime", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TimePrimitivePropertyType {
        
        private AbstractTimePrimitiveType _TimePrimitiveField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractTimePrimitiveType _TimePrimitive {
            get {
                return this._TimePrimitiveField;
            }
            set {
                this._TimePrimitiveField = value;
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
