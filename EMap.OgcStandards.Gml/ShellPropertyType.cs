﻿namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class ShellPropertyType {
        
        private ShellType shellField;
        
        /// <remarks/>
        public ShellType Shell {
            get {
                return this.shellField;
            }
            set {
                this.shellField = value;
            }
        }
    }
}
