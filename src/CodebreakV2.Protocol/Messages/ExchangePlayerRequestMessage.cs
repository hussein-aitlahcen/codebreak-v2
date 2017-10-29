using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangePlayerRequestMessage : ExchangeRequestMessage
	{
		public Int64 Target { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(Target);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Target = reader.ReadVarLong();
		}
	}
}
