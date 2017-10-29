namespace CodebreakV2.ProtocolBuilder
{
    public sealed class Protocol
    {
        public Message[] Messages { get; set; }
        public Message[] Types { get; set; }
        public Enum[] Enums { get; set; }
    }
}