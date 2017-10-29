using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectSetPositionMessage
	{
		public UInt32 ObjectUID { get; set; }
		public Byte Position { get; set; }
		public UInt32 Quantity { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ObjectUID);
			writer.WriteByte(Position);
			writer.WriteVarInt((Int32)Quantity);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectUID = (UInt32)reader.ReadVarInt();
			Position = reader.ReadByte();
			Quantity = (UInt32)reader.ReadVarInt();
		}
	}
}
