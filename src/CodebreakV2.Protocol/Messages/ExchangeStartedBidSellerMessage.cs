using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartedBidSellerMessage
	{
		public SellerBuyerDescriptor SellerDescriptor { get; set; }
		public ObjectItemToSellInBid[] ObjectsInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			SellerDescriptor.Serialize(writer);
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				ObjectsInfos[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			SellerDescriptor = new SellerBuyerDescriptor();
			SellerDescriptor.Deserialize(reader);
			ObjectsInfos = new ObjectItemToSellInBid[reader.ReadShort()];
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				(ObjectsInfos[i] = new ObjectItemToSellInBid()).Deserialize(reader);
			}
		}
	}
}
