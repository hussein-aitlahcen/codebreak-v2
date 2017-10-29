using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HouseSellRequestMessage
	{
		public UInt32 InstanceId { get; set; }
		public Int64 Amount { get; set; }
		public Boolean ForSale { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)InstanceId);
			writer.WriteVarLong(Amount);
			writer.WriteBoolean(ForSale);
		}
		public void Deserialize(IDataReader reader)
		{
			InstanceId = (UInt32)reader.ReadInt();
			Amount = reader.ReadVarLong();
			ForSale = reader.ReadBoolean();
		}
	}
}
