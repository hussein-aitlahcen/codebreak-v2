using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildFightPlayersEnemiesListMessage
	{
		public Double FightId { get; set; }
		public CharacterMinimalPlusLookInformations[] PlayerInfo { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(FightId);
			for (var i = 0; i < PlayerInfo.Length; i++)
			{
				PlayerInfo[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = reader.ReadDouble();
			PlayerInfo = new CharacterMinimalPlusLookInformations[reader.ReadShort()];
			for (var i = 0; i < PlayerInfo.Length; i++)
			{
				(PlayerInfo[i] = new CharacterMinimalPlusLookInformations()).Deserialize(reader);
			}
		}
	}
}
