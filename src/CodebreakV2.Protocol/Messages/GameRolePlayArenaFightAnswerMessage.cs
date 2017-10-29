using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayArenaFightAnswerMessage
	{
		public Int32 FightId { get; set; }
		public Boolean Accept { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(FightId);
			writer.WriteBoolean(Accept);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = reader.ReadInt();
			Accept = reader.ReadBoolean();
		}
	}
}
