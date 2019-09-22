﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("coordinateSystemRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CoordinateSystemRefType {
        
        private AbstractCoordinateSystemType _CoordinateSystemField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public AbstractCoordinateSystemType _CoordinateSystem {
            get {
                return this._CoordinateSystemField;
            }
            set {
                this._CoordinateSystemField = value;
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
