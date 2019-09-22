﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BSplineType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BezierType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CubicSplineType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodesicStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeodesicType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClothoidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OffsetCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcByCenterPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleByCenterPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcStringByBulgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcByBulgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringSegmentType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractCurveSegmentType {
        
        private string numDerivativesAtStartField;
        
        private string numDerivativesAtEndField;
        
        private string numDerivativeInteriorField;
        
        public AbstractCurveSegmentType() {
            this.numDerivativesAtStartField = "0";
            this.numDerivativesAtEndField = "0";
            this.numDerivativeInteriorField = "0";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string numDerivativesAtStart {
            get {
                return this.numDerivativesAtStartField;
            }
            set {
                this.numDerivativesAtStartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string numDerivativesAtEnd {
            get {
                return this.numDerivativesAtEndField;
            }
            set {
                this.numDerivativesAtEndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string numDerivativeInterior {
            get {
                return this.numDerivativeInteriorField;
            }
            set {
                this.numDerivativeInteriorField = value;
            }
        }
    }
}
