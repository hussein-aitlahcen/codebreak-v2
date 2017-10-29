using System;
namespace CodebreakV2.Protocol.Types
{
	public class SkillActionDescriptionCollect : SkillActionDescriptionTimed
	{
		public UInt16 Min { get; set; }
		public UInt16 Max { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)Min);
			writer.WriteVarShort((Int16)Max);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Min = (UInt16)reader.ReadVarShort();
			Max = (UInt16)reader.ReadVarShort();
		}
	}
}
