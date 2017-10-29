using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PaddockSellRequestMessage
	{
		public Int64 Price { get; set; }
		public Boolean ForSale { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(Price);
			writer.WriteBoolean(ForSale);
		}
		public void Deserialize(IDataReader reader)
		{
			Price = reader.ReadVarLong();
			ForSale = reader.ReadBoolean();
		}
	}
}
