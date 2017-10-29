using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicPingMessage
	{
		public Boolean Quiet { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Quiet);
		}
		public void Deserialize(IDataReader reader)
		{
			Quiet = reader.ReadBoolean();
		}
	}
}
