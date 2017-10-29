using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeTypesItemsExchangerDescriptionForUserMessage
	{
		public BidExchangerObjectInfo[] ItemTypeDescriptions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ItemTypeDescriptions.Length; i++)
			{
				ItemTypeDescriptions[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ItemTypeDescriptions = new BidExchangerObjectInfo[reader.ReadShort()];
			for (var i = 0; i < ItemTypeDescriptions.Length; i++)
			{
				(ItemTypeDescriptions[i] = new BidExchangerObjectInfo()).Deserialize(reader);
			}
		}
	}
}
