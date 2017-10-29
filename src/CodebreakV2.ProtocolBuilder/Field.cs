using System;

namespace CodebreakV2.ProtocolBuilder
{
    public sealed class Field
    {
        public int Length { get; set; }
        public int BBWPosition { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string WriteMethod { get; set; }
        public string WriteLengthMethod { get; set; }
        public string Method { get; set; }
        public bool IsVector { get; set; }
        public bool IsDynamicLength { get; set; }
        public bool UseTypeManager { get; set; }
        public bool UseBBW { get; set; }
    }
}