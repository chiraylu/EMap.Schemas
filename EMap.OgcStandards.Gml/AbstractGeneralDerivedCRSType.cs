﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivedCRSType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProjectedCRSType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractGeneralDerivedCRSType : AbstractReferenceSystemType {
        
        private CoordinateReferenceSystemRefType baseCRSField;
        
        private GeneralConversionRefType definedByConversionField;
        
        /// <remarks/>
        public CoordinateReferenceSystemRefType baseCRS {
            get {
                return this.baseCRSField;
            }
            set {
                this.baseCRSField = value;
            }
        }
        
        /// <remarks/>
        public GeneralConversionRefType definedByConversion {
            get {
                return this.definedByConversionField;
            }
            set {
                this.definedByConversionField = value;
            }
        }
    }
}
