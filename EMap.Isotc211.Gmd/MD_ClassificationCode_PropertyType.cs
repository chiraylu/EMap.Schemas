﻿using EMap.Isotc211.Gco;

namespace EMap.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_ClassificationCode_PropertyType {
        
        private CodeListValue_Type mD_ClassificationCodeField;
        
        private string nilReasonField;
        
        
        public CodeListValue_Type MD_ClassificationCode {
            get {
                return this.mD_ClassificationCodeField;
            }
            set {
                this.mD_ClassificationCodeField = value;
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
