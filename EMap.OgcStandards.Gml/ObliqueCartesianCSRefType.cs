﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("obliqueCartesianCSRef", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ObliqueCartesianCSRefType {
        
        private ObliqueCartesianCSType obliqueCartesianCSField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public ObliqueCartesianCSType ObliqueCartesianCS {
            get {
                return this.obliqueCartesianCSField;
            }
            set {
                this.obliqueCartesianCSField = value;
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
