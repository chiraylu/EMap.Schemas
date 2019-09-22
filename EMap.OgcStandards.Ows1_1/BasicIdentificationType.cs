﻿namespace EMap.OgcStandards.Ows1_1 {
    
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManifestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferenceGroupType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows/1.1")]
    public partial class BasicIdentificationType : DescriptionType {
        
        private CodeType identifierField;
        
        private MetadataType[] metadataField;
        
        
        public CodeType Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlElementAttribute("Metadata")]
        public MetadataType[] Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
    }
}
