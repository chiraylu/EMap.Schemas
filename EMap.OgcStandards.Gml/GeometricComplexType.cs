﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("GeometricComplex", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeometricComplexType : AbstractGeometryType {
        
        private GeometricPrimitivePropertyType[] elementField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("element")]
        public GeometricPrimitivePropertyType[] element {
            get {
                return this.elementField;
            }
            set {
                this.elementField = value;
            }
        }
    }
}
