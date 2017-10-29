using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobCrafterDirectoryRemoveMessage
	{
		public Byte JobId { get; set; }
		public Int64 PlayerId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(JobId);
			writer.WriteVarLong(PlayerId);
		}
		public void Deserialize(IDataReader reader)
		{
			JobId = reader.ReadByte();
			PlayerId = reader.ReadVarLong();
		}
	}
}
