using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobExperienceUpdateMessage
	{
		public JobExperience ExperiencesUpdate { get; set; }
		public void Serialize(IDataWriter writer)
		{
			ExperiencesUpdate.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			ExperiencesUpdate = new JobExperience();
			ExperiencesUpdate.Deserialize(reader);
		}
	}
}
