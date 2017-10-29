using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayPlayerFightFriendlyRequestedMessage
	{
		public UInt32 FightId { get; set; }
		public Int64 SourceId { get; set; }
		public Int64 TargetId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)FightId);
			writer.WriteVarLong(SourceId);
			writer.WriteVarLong(TargetId);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = (UInt32)reader.ReadInt();
			SourceId = reader.ReadVarLong();
			TargetId = reader.ReadVarLong();
		}
	}
}
