using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightResultPvpData : FightResultAdditionalData
	{
		public Byte Grade { get; set; }
		public UInt16 MinHonorForGrade { get; set; }
		public UInt16 MaxHonorForGrade { get; set; }
		public UInt16 Honor { get; set; }
		public Int16 HonorDelta { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Grade);
			writer.WriteVarShort((Int16)MinHonorForGrade);
			writer.WriteVarShort((Int16)MaxHonorForGrade);
			writer.WriteVarShort((Int16)Honor);
			writer.WriteVarShort(HonorDelta);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Grade = reader.ReadByte();
			MinHonorForGrade = (UInt16)reader.ReadVarShort();
			MaxHonorForGrade = (UInt16)reader.ReadVarShort();
			Honor = (UInt16)reader.ReadVarShort();
			HonorDelta = reader.ReadVarShort();
		}
	}
}
