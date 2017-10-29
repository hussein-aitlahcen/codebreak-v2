using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseUnsoldItemsMessage
	{
		public ObjectItemGenericQuantity[] Items { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Items.Length; i++)
			{
				Items[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Items = new ObjectItemGenericQuantity[reader.ReadShort()];
			for (var i = 0; i < Items.Length; i++)
			{
				(Items[i] = new ObjectItemGenericQuantity()).Deserialize(reader);
			}
		}
	}
}
