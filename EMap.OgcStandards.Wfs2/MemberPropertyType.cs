﻿using EMap.Xlink;

namespace EMap.OgcStandards.Wfs2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wfs/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("member", Namespace="http://www.opengis.net/wfs/2.0", IsNullable=false)]
    public partial class MemberPropertyType {
        
        private object itemField;
        
        private string[] textField;
        
        private string stateField;
        
        private typeType typeField;
        
        private bool typeFieldSpecified;
        
        private string hrefField;
        
        private string roleField;
        
        private string arcroleField;
        
        private string titleField;
        
        private showType showField;
        
        private bool showFieldSpecified;
        
        private actuateType actuateField;
        
        private bool actuateFieldSpecified;
        
        public MemberPropertyType() {
            this.typeField = typeType.simple;
        }
        
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("FeatureCollection", typeof(FeatureCollectionType))]
        [System.Xml.Serialization.XmlElementAttribute("SimpleFeatureCollection", typeof(SimpleFeatureCollectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Tuple", typeof(TupleType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink")]
        public typeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink", DataType="anyURI")]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink", DataType="anyURI")]
        public string role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink", DataType="anyURI")]
        public string arcrole {
            get {
                return this.arcroleField;
            }
            set {
                this.arcroleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink")]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink")]
        public showType show {
            get {
                return this.showField;
            }
            set {
                this.showField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showSpecified {
            get {
                return this.showFieldSpecified;
            }
            set {
                this.showFieldSpecified = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/1999/xlink")]
        public actuateType actuate {
            get {
                return this.actuateField;
            }
            set {
                this.actuateField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actuateSpecified {
            get {
                return this.actuateFieldSpecified;
            }
            set {
                this.actuateFieldSpecified = value;
            }
        }
    }
}
