﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("PolygonPatch", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class PolygonPatchType : AbstractSurfacePatchType {
        
        private AbstractRingPropertyType exteriorField;
        
        private AbstractRingPropertyType[] interiorField;
        
        private SurfaceInterpolationType interpolationField;
        
        private bool interpolationFieldSpecified;
        
        public PolygonPatchType() {
            this.interpolationField = SurfaceInterpolationType.planar;
        }
        
        
        public AbstractRingPropertyType exterior {
            get {
                return this.exteriorField;
            }
            set {
                this.exteriorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("interior")]
        public AbstractRingPropertyType[] interior {
            get {
                return this.interiorField;
            }
            set {
                this.interiorField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SurfaceInterpolationType interpolation {
            get {
                return this.interpolationField;
            }
            set {
                this.interpolationField = value;
            }
        }
        
        
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
