using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeOfflineSoldItemsMessage
	{
		public ObjectItemGenericQuantityPrice[] BidHouseItems { get; set; }
		public ObjectItemGenericQuantityPrice[] MerchantItems { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < BidHouseItems.Length; i++)
			{
				BidHouseItems[i].Serialize(writer);
			}
			for (var i = 0; i < MerchantItems.Length; i++)
			{
				MerchantItems[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			BidHouseItems = new ObjectItemGenericQuantityPrice[reader.ReadShort()];
			for (var i = 0; i < BidHouseItems.Length; i++)
			{
				(BidHouseItems[i] = new ObjectItemGenericQuantityPrice()).Deserialize(reader);
			}
			MerchantItems = new ObjectItemGenericQuantityPrice[reader.ReadShort()];
			for (var i = 0; i < MerchantItems.Length; i++)
			{
				(MerchantItems[i] = new ObjectItemGenericQuantityPrice()).Deserialize(reader);
			}
		}
	}
}
