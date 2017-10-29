using System;
namespace CodebreakV2.Protocol.Types
{
	public class JobCrafterDirectoryEntryJobInfo
	{
		public Byte JobId { get; set; }
		public Byte JobLevel { get; set; }
		public Boolean Free { get; set; }
		public Byte MinLevel { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(JobId);
			writer.WriteByte(JobLevel);
			writer.WriteBoolean(Free);
			writer.WriteByte(MinLevel);
		}
		public void Deserialize(IDataReader reader)
		{
			JobId = reader.ReadByte();
			JobLevel = reader.ReadByte();
			Free = reader.ReadBoolean();
			MinLevel = reader.ReadByte();
		}
	}
}
