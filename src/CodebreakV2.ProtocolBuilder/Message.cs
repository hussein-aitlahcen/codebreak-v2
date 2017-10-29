using System;

namespace CodebreakV2.ProtocolBuilder
{
    public sealed class Message
    {
        public int ProtocolId { get; set; }
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string Parent { get; set; }
        public bool UseHashFunc { get; set; }
        public Field[] Fields { get; set; }
    }
}