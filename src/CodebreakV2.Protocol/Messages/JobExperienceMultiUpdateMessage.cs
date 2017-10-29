using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobExperienceMultiUpdateMessage
	{
		public JobExperience[] ExperiencesUpdate { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ExperiencesUpdate.Length; i++)
			{
				ExperiencesUpdate[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ExperiencesUpdate = new JobExperience[reader.ReadShort()];
			for (var i = 0; i < ExperiencesUpdate.Length; i++)
			{
				(ExperiencesUpdate[i] = new JobExperience()).Deserialize(reader);
			}
		}
	}
}
