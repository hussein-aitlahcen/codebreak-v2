using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PaddockSellBuyDialogMessage
	{
		public Boolean Bsell { get; set; }
		public UInt32 OwnerId { get; set; }
		public Int64 Price { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Bsell);
			writer.WriteVarInt((Int32)OwnerId);
			writer.WriteVarLong(Price);
		}
		public void Deserialize(IDataReader reader)
		{
			Bsell = reader.ReadBoolean();
			OwnerId = (UInt32)reader.ReadVarInt();
			Price = reader.ReadVarLong();
		}
	}
}
