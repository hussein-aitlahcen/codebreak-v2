using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildFightPlayersHelpersJoinMessage
	{
		public Double FightId { get; set; }
		public CharacterMinimalPlusLookInformations PlayerInfo { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(FightId);
			PlayerInfo.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = reader.ReadDouble();
			PlayerInfo = new CharacterMinimalPlusLookInformations();
			PlayerInfo.Deserialize(reader);
		}
	}
}
