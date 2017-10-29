using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidPriceMessage
	{
		public UInt16 GenericId { get; set; }
		public Int64 AveragePrice { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)GenericId);
			writer.WriteVarLong(AveragePrice);
		}
		public void Deserialize(IDataReader reader)
		{
			GenericId = (UInt16)reader.ReadVarShort();
			AveragePrice = reader.ReadVarLong();
		}
	}
}
