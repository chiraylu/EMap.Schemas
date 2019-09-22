﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectedObservationAtDistanceType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DirectedObservation", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DirectedObservationType : ObservationType {
        
        private DirectionPropertyType directionField;
        
        /// <remarks/>
        public DirectionPropertyType direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
            }
        }
    }
}
