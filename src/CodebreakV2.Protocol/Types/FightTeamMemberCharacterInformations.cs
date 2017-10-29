using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
	{
		public String Name { get; set; }
		public Byte Level { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(Name);
			writer.WriteByte(Level);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Name = reader.ReadUTF();
			Level = reader.ReadByte();
		}
	}
}
