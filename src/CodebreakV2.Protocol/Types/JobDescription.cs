using System;
namespace CodebreakV2.Protocol.Types
{
	public class JobDescription
	{
		public Byte JobId { get; set; }
		public SkillActionDescription[] Skills { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(JobId);
			for (var i = 0; i < Skills.Length; i++)
			{
				Skills[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			JobId = reader.ReadByte();
			Skills = new SkillActionDescription[reader.ReadShort()];
			for (var i = 0; i < Skills.Length; i++)
			{
				(Skills[i] = new SkillActionDescription()).Deserialize(reader);
			}
		}
	}
}
