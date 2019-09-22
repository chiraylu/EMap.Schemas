﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompositeCurve", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CompositeCurveType : AbstractCurveType {
        
        private CurvePropertyType[] curveMemberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("curveMember")]
        public CurvePropertyType[] curveMember {
            get {
                return this.curveMemberField;
            }
            set {
                this.curveMemberField = value;
            }
        }
    }
}
