using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeCraftPaymentModificationRequestMessage
	{
		public Int64 Quantity { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(Quantity);
		}
		public void Deserialize(IDataReader reader)
		{
			Quantity = reader.ReadVarLong();
		}
	}
}
