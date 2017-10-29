using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayPlayerFightFriendlyAnsweredMessage
	{
		public Int32 FightId { get; set; }
		public Int64 SourceId { get; set; }
		public Int64 TargetId { get; set; }
		public Boolean Accept { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(FightId);
			writer.WriteVarLong(SourceId);
			writer.WriteVarLong(TargetId);
			writer.WriteBoolean(Accept);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = reader.ReadInt();
			SourceId = reader.ReadVarLong();
			TargetId = reader.ReadVarLong();
			Accept = reader.ReadBoolean();
		}
	}
}
