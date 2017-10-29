using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SubscriptionUpdateMessage
	{
		public Double Timestamp { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(Timestamp);
		}
		public void Deserialize(IDataReader reader)
		{
			Timestamp = reader.ReadDouble();
		}
	}
}
