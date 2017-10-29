using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeObjectMoveMessage
	{
		public UInt32 ObjectUID { get; set; }
		public Int32 Quantity { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ObjectUID);
			writer.WriteVarInt(Quantity);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectUID = (UInt32)reader.ReadVarInt();
			Quantity = reader.ReadVarInt();
		}
	}
}
