﻿using EMap.Isotc211.Gco;

namespace EMap.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class CI_PresentationFormCode_PropertyType {
        
        private CodeListValue_Type cI_PresentationFormCodeField;
        
        private string nilReasonField;
        
        
        public CodeListValue_Type CI_PresentationFormCode {
            get {
                return this.cI_PresentationFormCodeField;
            }
            set {
                this.cI_PresentationFormCodeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.isotc211.org/2005/gco")]
        public string nilReason {
            get {
                return this.nilReasonField;
            }
            set {
                this.nilReasonField = value;
            }
        }
    }
}
