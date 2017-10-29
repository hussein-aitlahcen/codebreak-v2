using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeReplyTaxVendorMessage
	{
		public Int64 ObjectValue { get; set; }
		public Int64 TotalTaxValue { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(ObjectValue);
			writer.WriteVarLong(TotalTaxValue);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectValue = reader.ReadVarLong();
			TotalTaxValue = reader.ReadVarLong();
		}
	}
}
