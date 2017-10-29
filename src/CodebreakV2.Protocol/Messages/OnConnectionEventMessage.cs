using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class OnConnectionEventMessage
	{
		public Byte EventType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(EventType);
		}
		public void Deserialize(IDataReader reader)
		{
			EventType = reader.ReadByte();
		}
	}
}
