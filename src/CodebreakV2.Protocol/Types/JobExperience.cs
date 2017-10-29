using System;
namespace CodebreakV2.Protocol.Types
{
	public class JobExperience
	{
		public Byte JobId { get; set; }
		public Byte JobLevel { get; set; }
		public Int64 JobXP { get; set; }
		public Int64 JobXpLevelFloor { get; set; }
		public Int64 JobXpNextLevelFloor { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(JobId);
			writer.WriteByte(JobLevel);
			writer.WriteVarLong(JobXP);
			writer.WriteVarLong(JobXpLevelFloor);
			writer.WriteVarLong(JobXpNextLevelFloor);
		}
		public void Deserialize(IDataReader reader)
		{
			JobId = reader.ReadByte();
			JobLevel = reader.ReadByte();
			JobXP = reader.ReadVarLong();
			JobXpLevelFloor = reader.ReadVarLong();
			JobXpNextLevelFloor = reader.ReadVarLong();
		}
	}
}
