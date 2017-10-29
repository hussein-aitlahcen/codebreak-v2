using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectJobAddedMessage
	{
		public Byte JobId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(JobId);
		}
		public void Deserialize(IDataReader reader)
		{
			JobId = reader.ReadByte();
		}
	}
}
