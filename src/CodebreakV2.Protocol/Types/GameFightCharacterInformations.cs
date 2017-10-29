using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightCharacterInformations : GameFightFighterNamedInformations
	{
		public Byte Level { get; set; }
		public ActorAlignmentInformations AlignmentInfos { get; set; }
		public SByte Breed { get; set; }
		public Boolean Sex { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Level);
			AlignmentInfos.Serialize(writer);
			writer.WriteByte((Byte)Breed);
			writer.WriteBoolean(Sex);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Level = reader.ReadByte();
			AlignmentInfos = new ActorAlignmentInformations();
			AlignmentInfos.Deserialize(reader);
			Breed = (SByte)reader.ReadByte();
			Sex = reader.ReadBoolean();
		}
	}
}
