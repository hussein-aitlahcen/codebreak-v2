using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTeamInformations : AbstractFightTeamInformations
	{
		public FightTeamMemberInformations[] TeamMembers { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < TeamMembers.Length; i++)
			{
				TeamMembers[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TeamMembers = new FightTeamMemberInformations[reader.ReadShort()];
			for (var i = 0; i < TeamMembers.Length; i++)
			{
				(TeamMembers[i] = new FightTeamMemberInformations()).Deserialize(reader);
			}
		}
	}
}
