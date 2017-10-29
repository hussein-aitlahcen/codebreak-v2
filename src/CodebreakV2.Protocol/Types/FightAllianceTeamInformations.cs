using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightAllianceTeamInformations : FightTeamInformations
	{
		public Byte Relation { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Relation);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Relation = reader.ReadByte();
		}
	}
}
