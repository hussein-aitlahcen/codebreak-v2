using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseInListRemovedMessage
	{
		public Int32 ItemUID { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(ItemUID);
		}
		public void Deserialize(IDataReader reader)
		{
			ItemUID = reader.ReadInt();
		}
	}
}
