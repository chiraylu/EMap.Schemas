﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("solidArrayProperty", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class SolidArrayPropertyType {
        
        private AbstractSolidType[] _SolidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Solid")]
        public AbstractSolidType[] _Solid {
            get {
                return this._SolidField;
            }
            set {
                this._SolidField = value;
            }
        }
    }
}
