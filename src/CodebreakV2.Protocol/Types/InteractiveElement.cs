using System;
namespace CodebreakV2.Protocol.Types
{
	public class InteractiveElement
	{
		public UInt32 ElementId { get; set; }
		public Int32 ElementTypeId { get; set; }
		public InteractiveElementSkill[] EnabledSkills { get; set; }
		public InteractiveElementSkill[] DisabledSkills { get; set; }
		public Boolean OnCurrentMap { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)ElementId);
			writer.WriteInt(ElementTypeId);
			for (var i = 0; i < EnabledSkills.Length; i++)
			{
				EnabledSkills[i].Serialize(writer);
			}
			for (var i = 0; i < DisabledSkills.Length; i++)
			{
				DisabledSkills[i].Serialize(writer);
			}
			writer.WriteBoolean(OnCurrentMap);
		}
		public void Deserialize(IDataReader reader)
		{
			ElementId = (UInt32)reader.ReadInt();
			ElementTypeId = reader.ReadInt();
			EnabledSkills = new InteractiveElementSkill[reader.ReadShort()];
			for (var i = 0; i < EnabledSkills.Length; i++)
			{
				(EnabledSkills[i] = new InteractiveElementSkill()).Deserialize(reader);
			}
			DisabledSkills = new InteractiveElementSkill[reader.ReadShort()];
			for (var i = 0; i < DisabledSkills.Length; i++)
			{
				(DisabledSkills[i] = new InteractiveElementSkill()).Deserialize(reader);
			}
			OnCurrentMap = reader.ReadBoolean();
		}
	}
}
