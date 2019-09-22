﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.OgcStandards.Wmts1
{
    public class OverrideAttribute
    {
        public string BaseElementName { get; set; }
        public Type BaseType { get; set; }
        public Dictionary<string, Type> Inheritors { get; set; } = new Dictionary<string, Type>();
    }
}
