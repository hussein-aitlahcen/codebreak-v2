using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseItemRemoveOkMessage
	{
		public Int32 SellerId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(SellerId);
		}
		public void Deserialize(IDataReader reader)
		{
			SellerId = reader.ReadInt();
		}
	}
}
