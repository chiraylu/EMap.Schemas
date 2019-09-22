﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("exterior", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class AbstractRingPropertyType {
        
        private AbstractRingType _RingField;
        
        /// <remarks/>
        public AbstractRingType _Ring {
            get {
                return this._RingField;
            }
            set {
                this._RingField = value;
            }
        }
    }
}
