﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("PassThroughOperation", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class PassThroughOperationType : AbstractCoordinateOperationType {
        
        private string[] modifiedCoordinateField;
        
        private CoordinateOperationPropertyType coordOperationField;
        
        private AggregationType aggregationTypeField;
        
        private bool aggregationTypeFieldSpecified;
        
        
        [System.Xml.Serialization.XmlElementAttribute("modifiedCoordinate", DataType="positiveInteger")]
        public string[] modifiedCoordinate {
            get {
                return this.modifiedCoordinateField;
            }
            set {
                this.modifiedCoordinateField = value;
            }
        }
        
        
        public CoordinateOperationPropertyType coordOperation {
            get {
                return this.coordOperationField;
            }
            set {
                this.coordOperationField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AggregationType aggregationType {
            get {
                return this.aggregationTypeField;
            }
            set {
                this.aggregationTypeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggregationTypeSpecified {
            get {
                return this.aggregationTypeFieldSpecified;
            }
            set {
                this.aggregationTypeFieldSpecified = value;
            }
        }
    }
}
