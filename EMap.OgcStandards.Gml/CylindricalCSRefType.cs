﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("cylindricalCSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CylindricalCSRefType {
        
        private CylindricalCSType cylindricalCSField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public CylindricalCSType CylindricalCS {
            get {
                return this.cylindricalCSField;
            }
            set {
                this.cylindricalCSField = value;
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
