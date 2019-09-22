﻿using EMap.OgcStandards.Wmts1;
using System.IO;

namespace EMap.OgcStandards.Services
{
    public interface IWmtsService:IOgcService
    {
        void XmlSerialize(TextWriter textWriter,Capabilities capabilities);
        Capabilities XmlDeSerialize(TextReader textReader);
        Capabilities CreateCapabilities(string href);
        LayerType AddLayerType(Capabilities capabilities, string dataPath);
        void RemoveLayerType(Capabilities capabilities, string layerName);
        Capabilities GetCapabilities(string capabilitiesPath, GetCapabilities getCapabilities);
        byte[] GetTile(Capabilities capabilities, string path, GetTile getTile);
        FeatureInfoResponse GetFeatureInfo(Capabilities capabilities, string capabilitiesPath, GetFeatureInfo getFeatureInfo);
    }
}
