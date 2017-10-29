using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountFeedRequestMessage
	{
		public UInt32 MountUid { get; set; }
		public SByte MountLocation { get; set; }
		public UInt32 MountFoodUid { get; set; }
		public UInt32 Quantity { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)MountUid);
			writer.WriteByte((Byte)MountLocation);
			writer.WriteVarInt((Int32)MountFoodUid);
			writer.WriteVarInt((Int32)Quantity);
		}
		public void Deserialize(IDataReader reader)
		{
			MountUid = (UInt32)reader.ReadVarInt();
			MountLocation = (SByte)reader.ReadByte();
			MountFoodUid = (UInt32)reader.ReadVarInt();
			Quantity = (UInt32)reader.ReadVarInt();
		}
	}
}
