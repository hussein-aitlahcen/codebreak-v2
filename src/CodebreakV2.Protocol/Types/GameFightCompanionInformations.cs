using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightCompanionInformations : GameFightFighterInformations
	{
		public Byte CompanionGenericId { get; set; }
		public Byte Level { get; set; }
		public Double MasterId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(CompanionGenericId);
			writer.WriteByte(Level);
			writer.WriteDouble(MasterId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CompanionGenericId = reader.ReadByte();
			Level = reader.ReadByte();
			MasterId = reader.ReadDouble();
		}
	}
}
