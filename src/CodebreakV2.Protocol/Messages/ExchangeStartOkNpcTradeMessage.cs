using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartOkNpcTradeMessage
	{
		public Double NpcId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(NpcId);
		}
		public void Deserialize(IDataReader reader)
		{
			NpcId = reader.ReadDouble();
		}
	}
}
