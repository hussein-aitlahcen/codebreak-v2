using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeShopStockMultiMovementUpdatedMessage
	{
		public ObjectItemToSell[] ObjectInfoList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ObjectInfoList.Length; i++)
			{
				ObjectInfoList[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectInfoList = new ObjectItemToSell[reader.ReadShort()];
			for (var i = 0; i < ObjectInfoList.Length; i++)
			{
				(ObjectInfoList[i] = new ObjectItemToSell()).Deserialize(reader);
			}
		}
	}
}
