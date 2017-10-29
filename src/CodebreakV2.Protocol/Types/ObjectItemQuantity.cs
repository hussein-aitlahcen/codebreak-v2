using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectItemQuantity : Item
	{
		public UInt32 ObjectUID { get; set; }
		public UInt32 Quantity { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)ObjectUID);
			writer.WriteVarInt((Int32)Quantity);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ObjectUID = (UInt32)reader.ReadVarInt();
			Quantity = (UInt32)reader.ReadVarInt();
		}
	}
}
