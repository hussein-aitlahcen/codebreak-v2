using System;
namespace CodebreakV2.Protocol.Types
{
	public class InteractiveElementSkill
	{
		public UInt32 SkillId { get; set; }
		public UInt32 SkillInstanceUid { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)SkillId);
			writer.WriteInt((Int32)SkillInstanceUid);
		}
		public void Deserialize(IDataReader reader)
		{
			SkillId = (UInt32)reader.ReadVarInt();
			SkillInstanceUid = (UInt32)reader.ReadInt();
		}
	}
}
