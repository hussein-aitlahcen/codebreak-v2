using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChallengeInfoMessage
	{
		public UInt16 ChallengeId { get; set; }
		public Double TargetId { get; set; }
		public UInt32 XpBonus { get; set; }
		public UInt32 DropBonus { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ChallengeId);
			writer.WriteDouble(TargetId);
			writer.WriteVarInt((Int32)XpBonus);
			writer.WriteVarInt((Int32)DropBonus);
		}
		public void Deserialize(IDataReader reader)
		{
			ChallengeId = (UInt16)reader.ReadVarShort();
			TargetId = reader.ReadDouble();
			XpBonus = (UInt32)reader.ReadVarInt();
			DropBonus = (UInt32)reader.ReadVarInt();
		}
	}
}
