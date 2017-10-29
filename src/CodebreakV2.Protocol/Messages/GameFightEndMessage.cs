using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightEndMessage
	{
		public UInt32 Duration { get; set; }
		public Int16 AgeBonus { get; set; }
		public Int16 LootShareLimitMalus { get; set; }
		public FightResultListEntry[] Results { get; set; }
		public NamedPartyTeamWithOutcome[] NamedPartyTeamsOutcomes { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)Duration);
			writer.WriteShort(AgeBonus);
			writer.WriteShort(LootShareLimitMalus);
			for (var i = 0; i < Results.Length; i++)
			{
				Results[i].Serialize(writer);
			}
			for (var i = 0; i < NamedPartyTeamsOutcomes.Length; i++)
			{
				NamedPartyTeamsOutcomes[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Duration = (UInt32)reader.ReadInt();
			AgeBonus = reader.ReadShort();
			LootShareLimitMalus = reader.ReadShort();
			Results = new FightResultListEntry[reader.ReadShort()];
			for (var i = 0; i < Results.Length; i++)
			{
				(Results[i] = new FightResultListEntry()).Deserialize(reader);
			}
			NamedPartyTeamsOutcomes = new NamedPartyTeamWithOutcome[reader.ReadShort()];
			for (var i = 0; i < NamedPartyTeamsOutcomes.Length; i++)
			{
				(NamedPartyTeamsOutcomes[i] = new NamedPartyTeamWithOutcome()).Deserialize(reader);
			}
		}
	}
}
