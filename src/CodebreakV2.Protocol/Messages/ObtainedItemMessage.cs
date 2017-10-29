using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObtainedItemMessage
	{
		public UInt16 GenericId { get; set; }
		public UInt32 BaseQuantity { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)GenericId);
			writer.WriteVarInt((Int32)BaseQuantity);
		}
		public void Deserialize(IDataReader reader)
		{
			GenericId = (UInt16)reader.ReadVarShort();
			BaseQuantity = (UInt32)reader.ReadVarInt();
		}
	}
}
