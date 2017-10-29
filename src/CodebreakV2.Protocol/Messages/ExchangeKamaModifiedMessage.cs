using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeKamaModifiedMessage : ExchangeObjectMessage
	{
		public Int64 Quantity { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(Quantity);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Quantity = reader.ReadVarLong();
		}
	}
}
