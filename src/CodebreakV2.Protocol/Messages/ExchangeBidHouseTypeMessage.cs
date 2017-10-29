using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseTypeMessage
	{
		public UInt32 Type { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)Type);
		}
		public void Deserialize(IDataReader reader)
		{
			Type = (UInt32)reader.ReadVarInt();
		}
	}
}
