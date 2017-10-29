using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTeamMemberCompanionInformations : FightTeamMemberInformations
	{
		public Byte CompanionId { get; set; }
		public Byte Level { get; set; }
		public Double MasterId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(CompanionId);
			writer.WriteByte(Level);
			writer.WriteDouble(MasterId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CompanionId = reader.ReadByte();
			Level = reader.ReadByte();
			MasterId = reader.ReadDouble();
		}
	}
}
