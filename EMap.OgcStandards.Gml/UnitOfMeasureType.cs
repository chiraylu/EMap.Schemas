﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionToPreferredUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DerivationUnitTermType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("unitOfMeasure", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class UnitOfMeasureType {
        
        private string uomField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
    }
}
