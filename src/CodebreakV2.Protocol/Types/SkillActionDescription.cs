using System;
namespace CodebreakV2.Protocol.Types
{
	public class SkillActionDescription
	{
		public UInt16 SkillId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SkillId);
		}
		public void Deserialize(IDataReader reader)
		{
			SkillId = (UInt16)reader.ReadVarShort();
		}
	}
}
