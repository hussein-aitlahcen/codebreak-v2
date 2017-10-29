using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTeamMemberMonsterInformations : FightTeamMemberInformations
	{
		public Int32 MonsterId { get; set; }
		public Byte Grade { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(MonsterId);
			writer.WriteByte(Grade);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MonsterId = reader.ReadInt();
			Grade = reader.ReadByte();
		}
	}
}
