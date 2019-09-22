﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeOrdinalEra", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeOrdinalEraType : DefinitionType {
        
        private RelatedTimeType[] relatedTimeField;
        
        private TimeNodePropertyType startField;
        
        private TimeNodePropertyType endField;
        
        private TimePeriodPropertyType extentField;
        
        private TimeOrdinalEraPropertyType[] memberField;
        
        private ReferenceType groupField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("relatedTime")]
        public RelatedTimeType[] relatedTime {
            get {
                return this.relatedTimeField;
            }
            set {
                this.relatedTimeField = value;
            }
        }
        
        
        public TimeNodePropertyType start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
            }
        }
        
        
        public TimeNodePropertyType end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
            }
        }
        
        
        public TimePeriodPropertyType extent {
            get {
                return this.extentField;
            }
            set {
                this.extentField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("member")]
        public TimeOrdinalEraPropertyType[] member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
        
        
        public ReferenceType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
    }
}
