﻿namespace EMap.OgcStandards.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlRootAttribute("parameterValue", Namespace="http://www.opengis.net/gml/3.2", IsNullable=false)]
    public partial class AbstractGeneralParameterValuePropertyType {
        
        private AbstractGeneralParameterValueType abstractGeneralParameterValueField;
        
        
        public AbstractGeneralParameterValueType AbstractGeneralParameterValue {
            get {
                return this.abstractGeneralParameterValueField;
            }
            set {
                this.abstractGeneralParameterValueField = value;
            }
        }
    }
}
