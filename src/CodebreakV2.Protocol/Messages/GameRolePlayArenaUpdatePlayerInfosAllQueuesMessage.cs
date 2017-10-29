using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage : GameRolePlayArenaUpdatePlayerInfosMessage
	{
		public ArenaRankInfos Team { get; set; }
		public ArenaRankInfos Duel { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Team.Serialize(writer);
			Duel.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Team = new ArenaRankInfos();
			Team.Deserialize(reader);
			Duel = new ArenaRankInfos();
			Duel.Deserialize(reader);
		}
	}
}
