using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeShopStockMultiMovementRemovedMessage
	{
		public UInt32[] ObjectIdList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ObjectIdList.Length; i++)
			{
				writer.WriteVarInt((Int32)ObjectIdList[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectIdList = new UInt32[reader.ReadShort()];
			for (var i = 0; i < ObjectIdList.Length; i++)
			{
				ObjectIdList[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
