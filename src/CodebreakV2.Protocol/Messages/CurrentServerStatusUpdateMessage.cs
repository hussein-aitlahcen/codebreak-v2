using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CurrentServerStatusUpdateMessage
	{
		public Byte Status { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Status);
		}
		public void Deserialize(IDataReader reader)
		{
			Status = reader.ReadByte();
		}
	}
}
