using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidPriceForSellerMessage : ExchangeBidPriceMessage
	{
		public Boolean AllIdentical { get; set; }
		public Int64[] MinimalPrices { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(AllIdentical);
			for (var i = 0; i < MinimalPrices.Length; i++)
			{
				writer.WriteVarLong(MinimalPrices[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			AllIdentical = reader.ReadBoolean();
			MinimalPrices = new Int64[reader.ReadShort()];
			for (var i = 0; i < MinimalPrices.Length; i++)
			{
				MinimalPrices[i] = reader.ReadVarLong();
			}
		}
	}
}
