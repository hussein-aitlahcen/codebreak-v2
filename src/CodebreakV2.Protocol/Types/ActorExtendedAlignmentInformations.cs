using System;
namespace CodebreakV2.Protocol.Types
{
	public class ActorExtendedAlignmentInformations : ActorAlignmentInformations
	{
		public UInt16 Honor { get; set; }
		public UInt16 HonorGradeFloor { get; set; }
		public UInt16 HonorNextGradeFloor { get; set; }
		public Byte Aggressable { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)Honor);
			writer.WriteVarShort((Int16)HonorGradeFloor);
			writer.WriteVarShort((Int16)HonorNextGradeFloor);
			writer.WriteByte(Aggressable);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Honor = (UInt16)reader.ReadVarShort();
			HonorGradeFloor = (UInt16)reader.ReadVarShort();
			HonorNextGradeFloor = (UInt16)reader.ReadVarShort();
			Aggressable = reader.ReadByte();
		}
	}
}
