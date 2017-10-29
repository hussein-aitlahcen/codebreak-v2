using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PaddockBuyResultMessage
	{
		public Double PaddockId { get; set; }
		public Boolean Bought { get; set; }
		public Int64 RealPrice { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(PaddockId);
			writer.WriteBoolean(Bought);
			writer.WriteVarLong(RealPrice);
		}
		public void Deserialize(IDataReader reader)
		{
			PaddockId = reader.ReadDouble();
			Bought = reader.ReadBoolean();
			RealPrice = reader.ReadVarLong();
		}
	}
}
