using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightUpdateTeamMessage
	{
		public UInt16 FightId { get; set; }
		public FightTeamInformations Team { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort((Int16)FightId);
			Team.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = (UInt16)reader.ReadShort();
			Team = new FightTeamInformations();
			Team.Deserialize(reader);
		}
	}
}
