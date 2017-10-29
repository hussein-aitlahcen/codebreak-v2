using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayArenaUpdatePlayerInfosMessage
	{
		public ArenaRankInfos Solo { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Solo.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Solo = new ArenaRankInfos();
			Solo.Deserialize(reader);
		}
	}
}
