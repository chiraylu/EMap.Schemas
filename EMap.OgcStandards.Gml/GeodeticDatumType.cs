﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeodeticDatum", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeodeticDatumType : AbstractDatumType {
        
        private PrimeMeridianRefType usesPrimeMeridianField;
        
        private EllipsoidRefType usesEllipsoidField;
        
        /// <remarks/>
        public PrimeMeridianRefType usesPrimeMeridian {
            get {
                return this.usesPrimeMeridianField;
            }
            set {
                this.usesPrimeMeridianField = value;
            }
        }
        
        /// <remarks/>
        public EllipsoidRefType usesEllipsoid {
            get {
                return this.usesEllipsoidField;
            }
            set {
                this.usesEllipsoidField = value;
            }
        }
    }
}
