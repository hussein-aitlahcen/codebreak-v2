using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightExternalInformations
	{
		public Int32 FightId { get; set; }
		public Byte FightType { get; set; }
		public UInt32 FightStart { get; set; }
		public Boolean FightSpectatorLocked { get; set; }
		public FightTeamLightInformations[] FightTeams { get; set; }
		public FightOptionsInformations[] FightTeamsOptions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(FightId);
			writer.WriteByte(FightType);
			writer.WriteInt((Int32)FightStart);
			writer.WriteBoolean(FightSpectatorLocked);
			for (var i = 0; i < FightTeams.Length; i++)
			{
				FightTeams[i].Serialize(writer);
			}
			for (var i = 0; i < FightTeamsOptions.Length; i++)
			{
				FightTeamsOptions[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = reader.ReadInt();
			FightType = reader.ReadByte();
			FightStart = (UInt32)reader.ReadInt();
			FightSpectatorLocked = reader.ReadBoolean();
			FightTeams = new FightTeamLightInformations[2];
			for (var i = 0; i < FightTeams.Length; i++)
			{
				(FightTeams[i] = new FightTeamLightInformations()).Deserialize(reader);
			}
			FightTeamsOptions = new FightOptionsInformations[2];
			for (var i = 0; i < FightTeamsOptions.Length; i++)
			{
				(FightTeamsOptions[i] = new FightOptionsInformations()).Deserialize(reader);
			}
		}
	}
}
