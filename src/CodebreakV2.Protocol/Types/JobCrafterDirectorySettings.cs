using System;
namespace CodebreakV2.Protocol.Types
{
	public class JobCrafterDirectorySettings
	{
		public Byte JobId { get; set; }
		public Byte MinLevel { get; set; }
		public Boolean Free { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(JobId);
			writer.WriteByte(MinLevel);
			writer.WriteBoolean(Free);
		}
		public void Deserialize(IDataReader reader)
		{
			JobId = reader.ReadByte();
			MinLevel = reader.ReadByte();
			Free = reader.ReadBoolean();
		}
	}
}
