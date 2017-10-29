using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeObjectMovePricedMessage : ExchangeObjectMoveMessage
	{
		public Int64 Price { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(Price);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Price = reader.ReadVarLong();
		}
	}
}
