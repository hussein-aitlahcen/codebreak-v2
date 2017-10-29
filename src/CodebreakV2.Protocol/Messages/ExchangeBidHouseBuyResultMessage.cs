using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseBuyResultMessage
	{
		public UInt32 Uid { get; set; }
		public Boolean Bought { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)Uid);
			writer.WriteBoolean(Bought);
		}
		public void Deserialize(IDataReader reader)
		{
			Uid = (UInt32)reader.ReadVarInt();
			Bought = reader.ReadBoolean();
		}
	}
}
