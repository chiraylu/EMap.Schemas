﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ImageDatum", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ImageDatumType : AbstractDatumType {
        
        private PixelInCellType pixelInCellField;
        
        /// <remarks/>
        public PixelInCellType pixelInCell {
            get {
                return this.pixelInCellField;
            }
            set {
                this.pixelInCellField = value;
            }
        }
    }
}
