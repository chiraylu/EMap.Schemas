﻿using EMap.Isotc211.Gco;

namespace EMap.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_CellGeometryCode_PropertyType {
        
        private CodeListValue_Type mD_CellGeometryCodeField;
        
        private string nilReasonField;
        
        
        public CodeListValue_Type MD_CellGeometryCode {
            get {
                return this.mD_CellGeometryCodeField;
            }
            set {
                this.mD_CellGeometryCodeField = value;
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
