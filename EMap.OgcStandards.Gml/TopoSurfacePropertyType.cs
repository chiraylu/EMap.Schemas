﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("topoSurfaceProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoSurfacePropertyType {
        
        private TopoSurfaceType topoSurfaceField;
        
        /// <remarks/>
        public TopoSurfaceType TopoSurface {
            get {
                return this.topoSurfaceField;
            }
            set {
                this.topoSurfaceField = value;
            }
        }
    }
}
