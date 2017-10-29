using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeShopStockMovementUpdatedMessage
	{
		public ObjectItemToSell ObjectInfo { get; set; }
		public void Serialize(IDataWriter writer)
		{
			ObjectInfo.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectInfo = new ObjectItemToSell();
			ObjectInfo.Deserialize(reader);
		}
	}
}
