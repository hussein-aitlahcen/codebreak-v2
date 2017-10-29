using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LockableStateUpdateHouseDoorMessage : LockableStateUpdateAbstractMessage
	{
		public UInt32 HouseId { get; set; }
		public UInt32 InstanceId { get; set; }
		public Boolean SecondHand { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)HouseId);
			writer.WriteInt((Int32)InstanceId);
			writer.WriteBoolean(SecondHand);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			HouseId = (UInt32)reader.ReadVarInt();
			InstanceId = (UInt32)reader.ReadInt();
			SecondHand = reader.ReadBoolean();
		}
	}
}
