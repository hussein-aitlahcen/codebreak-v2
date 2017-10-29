using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectItemGenericQuantity : Item
	{
		public UInt16 ObjectGID { get; set; }
		public UInt32 Quantity { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)ObjectGID);
			writer.WriteVarInt((Int32)Quantity);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ObjectGID = (UInt16)reader.ReadVarShort();
			Quantity = (UInt32)reader.ReadVarInt();
		}
	}
}
