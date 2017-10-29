using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseItemAddOkMessage
	{
		public ObjectItemToSellInBid ItemInfo { get; set; }
		public void Serialize(IDataWriter writer)
		{
			ItemInfo.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			ItemInfo = new ObjectItemToSellInBid();
			ItemInfo.Deserialize(reader);
		}
	}
}
