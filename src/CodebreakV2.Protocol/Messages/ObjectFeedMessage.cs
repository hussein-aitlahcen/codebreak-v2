using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectFeedMessage
	{
		public UInt32 ObjectUID { get; set; }
		public UInt32 FoodUID { get; set; }
		public UInt32 FoodQuantity { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ObjectUID);
			writer.WriteVarInt((Int32)FoodUID);
			writer.WriteVarInt((Int32)FoodQuantity);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectUID = (UInt32)reader.ReadVarInt();
			FoodUID = (UInt32)reader.ReadVarInt();
			FoodQuantity = (UInt32)reader.ReadVarInt();
		}
	}
}
