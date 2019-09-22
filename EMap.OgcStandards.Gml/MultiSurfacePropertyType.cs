﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("multiSurfaceProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class MultiSurfacePropertyType {
        
        private MultiSurfaceType multiSurfaceField;
        
        private string remoteSchemaField;
        
        /// <remarks/>
        public MultiSurfaceType MultiSurface {
            get {
                return this.multiSurfaceField;
            }
            set {
                this.multiSurfaceField = value;
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
