﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("geocentricCRSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeocentricCRSRefType {
        
        private GeocentricCRSType geocentricCRSField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public GeocentricCRSType GeocentricCRS {
            get {
                return this.geocentricCRSField;
            }
            set {
                this.geocentricCRSField = value;
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
