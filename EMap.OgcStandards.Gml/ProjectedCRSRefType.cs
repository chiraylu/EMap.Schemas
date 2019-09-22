﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("projectedCRSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ProjectedCRSRefType {
        
        private ProjectedCRSType projectedCRSField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public ProjectedCRSType ProjectedCRS {
            get {
                return this.projectedCRSField;
            }
            set {
                this.projectedCRSField = value;
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
