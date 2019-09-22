﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("TimeCalendar", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class TimeCalendarType : TimeReferenceSystemType {
        
        private TimeCalendarEraPropertyType[] referenceFrameField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("referenceFrame")]
        public TimeCalendarEraPropertyType[] referenceFrame {
            get {
                return this.referenceFrameField;
            }
            set {
                this.referenceFrameField = value;
            }
        }
    }
}
