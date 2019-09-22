﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyhedralSurfaceType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Surface", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class SurfaceType : AbstractSurfaceType {
        
        private SurfacePatchArrayPropertyType patchesField;
        
        /// <remarks/>
        public SurfacePatchArrayPropertyType patches {
            get {
                return this.patchesField;
            }
            set {
                this.patchesField = value;
            }
        }
    }
}
