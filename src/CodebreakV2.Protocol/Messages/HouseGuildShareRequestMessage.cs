using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HouseGuildShareRequestMessage
	{
		public UInt32 HouseId { get; set; }
		public UInt32 InstanceId { get; set; }
		public Boolean Enable { get; set; }
		public UInt32 Rights { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)HouseId);
			writer.WriteInt((Int32)InstanceId);
			writer.WriteBoolean(Enable);
			writer.WriteVarInt((Int32)Rights);
		}
		public void Deserialize(IDataReader reader)
		{
			HouseId = (UInt32)reader.ReadVarInt();
			InstanceId = (UInt32)reader.ReadInt();
			Enable = reader.ReadBoolean();
			Rights = (UInt32)reader.ReadVarInt();
		}
	}
}
