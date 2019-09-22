﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("imageDatumRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ImageDatumRefType {
        
        private ImageDatumType imageDatumField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public ImageDatumType ImageDatum {
            get {
                return this.imageDatumField;
            }
            set {
                this.imageDatumField = value;
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
