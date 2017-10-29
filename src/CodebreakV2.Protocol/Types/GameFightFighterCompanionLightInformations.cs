using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightFighterCompanionLightInformations : GameFightFighterLightInformations
	{
		public Byte CompanionId { get; set; }
		public Double MasterId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(CompanionId);
			writer.WriteDouble(MasterId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CompanionId = reader.ReadByte();
			MasterId = reader.ReadDouble();
		}
	}
}
