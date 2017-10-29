using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseBuyMessage
	{
		public UInt32 Uid { get; set; }
		public UInt32 Qty { get; set; }
		public Int64 Price { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)Uid);
			writer.WriteVarInt((Int32)Qty);
			writer.WriteVarLong(Price);
		}
		public void Deserialize(IDataReader reader)
		{
			Uid = (UInt32)reader.ReadVarInt();
			Qty = (UInt32)reader.ReadVarInt();
			Price = reader.ReadVarLong();
		}
	}
}
