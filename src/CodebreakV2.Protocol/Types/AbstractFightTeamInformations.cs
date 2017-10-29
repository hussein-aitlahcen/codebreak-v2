using System;
namespace CodebreakV2.Protocol.Types
{
	public class AbstractFightTeamInformations
	{
		public Byte TeamId { get; set; }
		public Double LeaderId { get; set; }
		public SByte TeamSide { get; set; }
		public Byte TeamTypeId { get; set; }
		public Byte NbWaves { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(TeamId);
			writer.WriteDouble(LeaderId);
			writer.WriteByte((Byte)TeamSide);
			writer.WriteByte(TeamTypeId);
			writer.WriteByte(NbWaves);
		}
		public void Deserialize(IDataReader reader)
		{
			TeamId = reader.ReadByte();
			LeaderId = reader.ReadDouble();
			TeamSide = (SByte)reader.ReadByte();
			TeamTypeId = reader.ReadByte();
			NbWaves = reader.ReadByte();
		}
	}
}
