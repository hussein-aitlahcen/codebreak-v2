using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeSellMessage
	{
		public UInt32 ObjectToSellId { get; set; }
		public UInt32 Quantity { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ObjectToSellId);
			writer.WriteVarInt((Int32)Quantity);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectToSellId = (UInt32)reader.ReadVarInt();
			Quantity = (UInt32)reader.ReadVarInt();
		}
	}
}
