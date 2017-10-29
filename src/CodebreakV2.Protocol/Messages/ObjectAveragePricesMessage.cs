using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectAveragePricesMessage
	{
		public UInt16[] Ids { get; set; }
		public Int64[] AvgPrices { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Ids.Length; i++)
			{
				writer.WriteVarShort((Int16)Ids[i]);
			}
			for (var i = 0; i < AvgPrices.Length; i++)
			{
				writer.WriteVarLong(AvgPrices[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Ids = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Ids.Length; i++)
			{
				Ids[i] = (UInt16)reader.ReadVarShort();
			}
			AvgPrices = new Int64[reader.ReadShort()];
			for (var i = 0; i < AvgPrices.Length; i++)
			{
				AvgPrices[i] = reader.ReadVarLong();
			}
		}
	}
}
