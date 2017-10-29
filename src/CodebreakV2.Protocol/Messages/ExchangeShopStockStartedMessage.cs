using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeShopStockStartedMessage
	{
		public ObjectItemToSell[] ObjectsInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				ObjectsInfos[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectsInfos = new ObjectItemToSell[reader.ReadShort()];
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				(ObjectsInfos[i] = new ObjectItemToSell()).Deserialize(reader);
			}
		}
	}
}
