﻿using EMap.Isotc211.Gco;

namespace EMap.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_CoverageContentTypeCode_PropertyType {
        
        private CodeListValue_Type mD_CoverageContentTypeCodeField;
        
        private string nilReasonField;
        
        
        public CodeListValue_Type MD_CoverageContentTypeCode {
            get {
                return this.mD_CoverageContentTypeCodeField;
            }
            set {
                this.mD_CoverageContentTypeCodeField = value;
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
