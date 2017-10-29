using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeCraftPaymentModifiedMessage
	{
		public Int64 GoldSum { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(GoldSum);
		}
		public void Deserialize(IDataReader reader)
		{
			GoldSum = reader.ReadVarLong();
		}
	}
}
