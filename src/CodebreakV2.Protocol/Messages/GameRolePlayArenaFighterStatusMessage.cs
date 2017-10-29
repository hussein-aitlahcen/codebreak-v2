using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayArenaFighterStatusMessage
	{
		public Int32 FightId { get; set; }
		public Int32 PlayerId { get; set; }
		public Boolean Accepted { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(FightId);
			writer.WriteInt(PlayerId);
			writer.WriteBoolean(Accepted);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = reader.ReadInt();
			PlayerId = reader.ReadInt();
			Accepted = reader.ReadBoolean();
		}
	}
}
