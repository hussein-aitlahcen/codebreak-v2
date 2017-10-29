using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HouseTeleportRequestMessage
	{
		public UInt32 HouseId { get; set; }
		public UInt32 HouseInstanceId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)HouseId);
			writer.WriteInt((Int32)HouseInstanceId);
		}
		public void Deserialize(IDataReader reader)
		{
			HouseId = (UInt32)reader.ReadVarInt();
			HouseInstanceId = (UInt32)reader.ReadInt();
		}
	}
}
