using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeShopStockMovementRemovedMessage
	{
		public UInt32 ObjectId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ObjectId);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectId = (UInt32)reader.ReadVarInt();
		}
	}
}
