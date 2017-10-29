using System;
namespace CodebreakV2.Protocol.Types
{
	public class PaddockBuyableInformations
	{
		public Int64 Price { get; set; }
		public Boolean Locked { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(Price);
			writer.WriteBoolean(Locked);
		}
		public void Deserialize(IDataReader reader)
		{
			Price = reader.ReadVarLong();
			Locked = reader.ReadBoolean();
		}
	}
}
