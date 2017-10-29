using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobDescriptionMessage
	{
		public JobDescription[] JobsDescription { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < JobsDescription.Length; i++)
			{
				JobsDescription[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			JobsDescription = new JobDescription[reader.ReadShort()];
			for (var i = 0; i < JobsDescription.Length; i++)
			{
				(JobsDescription[i] = new JobDescription()).Deserialize(reader);
			}
		}
	}
}
