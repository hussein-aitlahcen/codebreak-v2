using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightSpectatorJoinMessage : GameFightJoinMessage
	{
		public NamedPartyTeam[] NamedPartyTeams { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < NamedPartyTeams.Length; i++)
			{
				NamedPartyTeams[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			NamedPartyTeams = new NamedPartyTeam[reader.ReadShort()];
			for (var i = 0; i < NamedPartyTeams.Length; i++)
			{
				(NamedPartyTeams[i] = new NamedPartyTeam()).Deserialize(reader);
			}
		}
	}
}
