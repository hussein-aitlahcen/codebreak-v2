using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicLatencyStatsMessage
	{
		public UInt16 Latency { get; set; }
		public UInt16 SampleCount { get; set; }
		public UInt16 Max { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort((Int16)Latency);
			writer.WriteVarShort((Int16)SampleCount);
			writer.WriteVarShort((Int16)Max);
		}
		public void Deserialize(IDataReader reader)
		{
			Latency = (UInt16)reader.ReadShort();
			SampleCount = (UInt16)reader.ReadVarShort();
			Max = (UInt16)reader.ReadVarShort();
		}
	}
}
