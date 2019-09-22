﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("Curve", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CurveType : AbstractCurveType {
        
        private AbstractCurveSegmentType[] segmentsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("_CurveSegment", IsNullable=false)]
        public AbstractCurveSegmentType[] segments {
            get {
                return this.segmentsField;
            }
            set {
                this.segmentsField = value;
            }
        }
    }
}
