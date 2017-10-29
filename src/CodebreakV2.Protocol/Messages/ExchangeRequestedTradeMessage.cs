using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
	{
		public Int64 Source { get; set; }
		public Int64 Target { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(Source);
			writer.WriteVarLong(Target);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Source = reader.ReadVarLong();
			Target = reader.ReadVarLong();
		}
	}
}
