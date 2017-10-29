using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightCommonInformations
	{
		public Int32 FightId { get; set; }
		public Byte FightType { get; set; }
		public FightTeamInformations[] FightTeams { get; set; }
		public UInt16[] FightTeamsPositions { get; set; }
		public FightOptionsInformations[] FightTeamsOptions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(FightId);
			writer.WriteByte(FightType);
			for (var i = 0; i < FightTeams.Length; i++)
			{
				FightTeams[i].Serialize(writer);
			}
			for (var i = 0; i < FightTeamsPositions.Length; i++)
			{
				writer.WriteVarShort((Int16)FightTeamsPositions[i]);
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
			FightTeams = new FightTeamInformations[reader.ReadShort()];
			for (var i = 0; i < FightTeams.Length; i++)
			{
				(FightTeams[i] = new FightTeamInformations()).Deserialize(reader);
			}
			FightTeamsPositions = new UInt16[reader.ReadShort()];
			for (var i = 0; i < FightTeamsPositions.Length; i++)
			{
				FightTeamsPositions[i] = (UInt16)reader.ReadVarShort();
			}
			FightTeamsOptions = new FightOptionsInformations[reader.ReadShort()];
			for (var i = 0; i < FightTeamsOptions.Length; i++)
			{
				(FightTeamsOptions[i] = new FightOptionsInformations()).Deserialize(reader);
			}
		}
	}
}
