using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartOkRecycleTradeMessage
	{
		public UInt16 PercentToPrism { get; set; }
		public UInt16 PercentToPlayer { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort((Int16)PercentToPrism);
			writer.WriteShort((Int16)PercentToPlayer);
		}
		public void Deserialize(IDataReader reader)
		{
			PercentToPrism = (UInt16)reader.ReadShort();
			PercentToPlayer = (UInt16)reader.ReadShort();
		}
	}
}
