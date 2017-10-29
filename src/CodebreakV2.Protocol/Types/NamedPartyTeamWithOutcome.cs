using System;
namespace CodebreakV2.Protocol.Types
{
	public class NamedPartyTeamWithOutcome
	{
		public NamedPartyTeam Team { get; set; }
		public UInt16 Outcome { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Team.Serialize(writer);
			writer.WriteVarShort((Int16)Outcome);
		}
		public void Deserialize(IDataReader reader)
		{
			Team = new NamedPartyTeam();
			Team.Deserialize(reader);
			Outcome = (UInt16)reader.ReadVarShort();
		}
	}
}
