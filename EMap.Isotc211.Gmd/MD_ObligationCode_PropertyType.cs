﻿namespace EMap.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_ObligationCode_PropertyType {
        
        private MD_ObligationCode_Type mD_ObligationCodeField;
        
        private string nilReasonField;
        
        
        public MD_ObligationCode_Type MD_ObligationCode {
            get {
                return this.mD_ObligationCodeField;
            }
            set {
                this.mD_ObligationCodeField = value;
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
