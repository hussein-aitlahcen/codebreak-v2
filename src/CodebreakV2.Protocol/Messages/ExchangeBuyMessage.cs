using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBuyMessage
	{
		public UInt32 ObjectToBuyId { get; set; }
		public UInt32 Quantity { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ObjectToBuyId);
			writer.WriteVarInt((Int32)Quantity);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectToBuyId = (UInt32)reader.ReadVarInt();
			Quantity = (UInt32)reader.ReadVarInt();
		}
	}
}
