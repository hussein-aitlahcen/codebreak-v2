using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareSubscribeRequestMessage
	{
		public Double DareId { get; set; }
		public Boolean Subscribe { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(DareId);
			writer.WriteBoolean(Subscribe);
		}
		public void Deserialize(IDataReader reader)
		{
			DareId = reader.ReadDouble();
			Subscribe = reader.ReadBoolean();
		}
	}
}
