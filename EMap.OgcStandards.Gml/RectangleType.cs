﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Rectangle", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class RectangleType : AbstractSurfacePatchType {
        
        private AbstractRingPropertyType exteriorField;
        
        private SurfaceInterpolationType interpolationField;
        
        private bool interpolationFieldSpecified;
        
        public RectangleType() {
            this.interpolationField = SurfaceInterpolationType.planar;
        }
        
        /// <remarks/>
        public AbstractRingPropertyType exterior {
            get {
                return this.exteriorField;
            }
            set {
                this.exteriorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SurfaceInterpolationType interpolation {
            get {
                return this.interpolationField;
            }
            set {
                this.interpolationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool interpolationSpecified {
            get {
                return this.interpolationFieldSpecified;
            }
            set {
                this.interpolationFieldSpecified = value;
            }
        }
    }
}
