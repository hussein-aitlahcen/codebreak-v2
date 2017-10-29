using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicTimeMessage
	{
		public Double Timestamp { get; set; }
		public Int16 TimezoneOffset { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(Timestamp);
			writer.WriteShort(TimezoneOffset);
		}
		public void Deserialize(IDataReader reader)
		{
			Timestamp = reader.ReadDouble();
			TimezoneOffset = reader.ReadShort();
		}
	}
}
