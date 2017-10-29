using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LoginQueueStatusMessage
	{
		public UInt16 Position { get; set; }
		public UInt16 Total { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort((Int16)Position);
			writer.WriteShort((Int16)Total);
		}
		public void Deserialize(IDataReader reader)
		{
			Position = (UInt16)reader.ReadShort();
			Total = (UInt16)reader.ReadShort();
		}
	}
}
