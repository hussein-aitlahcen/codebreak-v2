using System;
namespace CodebreakV2.Protocol.Types
{
	public class HumanOptionSkillUse : HumanOption
	{
		public UInt32 ElementId { get; set; }
		public UInt16 SkillId { get; set; }
		public Double SkillEndTime { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)ElementId);
			writer.WriteVarShort((Int16)SkillId);
			writer.WriteDouble(SkillEndTime);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ElementId = (UInt32)reader.ReadVarInt();
			SkillId = (UInt16)reader.ReadVarShort();
			SkillEndTime = reader.ReadDouble();
		}
	}
}
