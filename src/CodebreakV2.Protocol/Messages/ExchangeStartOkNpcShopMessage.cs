using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartOkNpcShopMessage
	{
		public Double NpcSellerId { get; set; }
		public UInt16 TokenId { get; set; }
		public ObjectItemToSellInNpcShop[] ObjectsInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(NpcSellerId);
			writer.WriteVarShort((Int16)TokenId);
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				ObjectsInfos[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			NpcSellerId = reader.ReadDouble();
			TokenId = (UInt16)reader.ReadVarShort();
			ObjectsInfos = new ObjectItemToSellInNpcShop[reader.ReadShort()];
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				(ObjectsInfos[i] = new ObjectItemToSellInNpcShop()).Deserialize(reader);
			}
		}
	}
}
