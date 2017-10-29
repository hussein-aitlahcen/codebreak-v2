using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayRemoveChallengeMessage
	{
		public Int32 FightId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(FightId);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = reader.ReadInt();
		}
	}
}
