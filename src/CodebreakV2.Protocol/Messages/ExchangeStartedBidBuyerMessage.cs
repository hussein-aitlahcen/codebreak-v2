using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartedBidBuyerMessage
	{
		public SellerBuyerDescriptor BuyerDescriptor { get; set; }
		public void Serialize(IDataWriter writer)
		{
			BuyerDescriptor.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			BuyerDescriptor = new SellerBuyerDescriptor();
			BuyerDescriptor.Deserialize(reader);
		}
	}
}
