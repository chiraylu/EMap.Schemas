﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrackType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("history", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class HistoryPropertyType {
        
        private AbstractTimeSliceType[] _TimeSliceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_TimeSlice")]
        public AbstractTimeSliceType[] _TimeSlice {
            get {
                return this._TimeSliceField;
            }
            set {
                this._TimeSliceField = value;
            }
        }
    }
}
