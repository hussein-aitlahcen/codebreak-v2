using System;
namespace CodebreakV2.Protocol.Types
{
	public class PrismInformation
	{
		public Byte TypeId { get; set; }
		public Byte State { get; set; }
		public UInt32 NextVulnerabilityDate { get; set; }
		public UInt32 PlacementDate { get; set; }
		public UInt32 RewardTokenCount { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(TypeId);
			writer.WriteByte(State);
			writer.WriteInt((Int32)NextVulnerabilityDate);
			writer.WriteInt((Int32)PlacementDate);
			writer.WriteVarInt((Int32)RewardTokenCount);
		}
		public void Deserialize(IDataReader reader)
		{
			TypeId = reader.ReadByte();
			State = reader.ReadByte();
			NextVulnerabilityDate = (UInt32)reader.ReadInt();
			PlacementDate = (UInt32)reader.ReadInt();
			RewardTokenCount = (UInt32)reader.ReadVarInt();
		}
	}
}
