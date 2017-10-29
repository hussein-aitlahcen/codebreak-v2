using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeWaitingResultMessage
	{
		public Boolean Bwait { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Bwait);
		}
		public void Deserialize(IDataReader reader)
		{
			Bwait = reader.ReadBoolean();
		}
	}
}
