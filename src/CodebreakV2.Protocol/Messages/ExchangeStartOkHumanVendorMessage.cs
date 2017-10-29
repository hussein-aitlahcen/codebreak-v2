using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartOkHumanVendorMessage
	{
		public Double SellerId { get; set; }
		public ObjectItemToSellInHumanVendorShop[] ObjectsInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(SellerId);
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				ObjectsInfos[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			SellerId = reader.ReadDouble();
			ObjectsInfos = new ObjectItemToSellInHumanVendorShop[reader.ReadShort()];
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				(ObjectsInfos[i] = new ObjectItemToSellInHumanVendorShop()).Deserialize(reader);
			}
		}
	}
}
