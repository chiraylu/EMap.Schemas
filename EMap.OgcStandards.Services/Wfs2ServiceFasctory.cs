﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.OgcStandards.Services
{
    public abstract class Wfs2ServiceFasctory : OgcServiceFasctory, IWfsServiceFasctory2
    {
        public new virtual IWfsService2 GetService()
        {
            throw new NotImplementedException();
        }
    }
}
