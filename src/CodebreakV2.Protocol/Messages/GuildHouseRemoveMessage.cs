using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildHouseRemoveMessage
	{
		public UInt32 HouseId { get; set; }
		public UInt32 InstanceId { get; set; }
		public Boolean SecondHand { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)HouseId);
			writer.WriteInt((Int32)InstanceId);
			writer.WriteBoolean(SecondHand);
		}
		public void Deserialize(IDataReader reader)
		{
			HouseId = (UInt32)reader.ReadVarInt();
			InstanceId = (UInt32)reader.ReadInt();
			SecondHand = reader.ReadBoolean();
		}
	}
}
