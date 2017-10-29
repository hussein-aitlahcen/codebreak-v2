using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobLevelUpMessage
	{
		public Byte NewLevel { get; set; }
		public JobDescription JobsDescription { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(NewLevel);
			JobsDescription.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			NewLevel = reader.ReadByte();
			JobsDescription = new JobDescription();
			JobsDescription.Deserialize(reader);
		}
	}
}
