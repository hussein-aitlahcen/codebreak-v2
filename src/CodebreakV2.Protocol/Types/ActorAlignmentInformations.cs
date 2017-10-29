using System;
namespace CodebreakV2.Protocol.Types
{
	public class ActorAlignmentInformations
	{
		public SByte AlignmentSide { get; set; }
		public Byte AlignmentValue { get; set; }
		public Byte AlignmentGrade { get; set; }
		public Double CharacterPower { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte((Byte)AlignmentSide);
			writer.WriteByte(AlignmentValue);
			writer.WriteByte(AlignmentGrade);
			writer.WriteDouble(CharacterPower);
		}
		public void Deserialize(IDataReader reader)
		{
			AlignmentSide = (SByte)reader.ReadByte();
			AlignmentValue = reader.ReadByte();
			AlignmentGrade = reader.ReadByte();
			CharacterPower = reader.ReadDouble();
		}
	}
}
