using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseSearchMessage
	{
		public UInt32 Type { get; set; }
		public UInt16 GenId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)Type);
			writer.WriteVarShort((Int16)GenId);
		}
		public void Deserialize(IDataReader reader)
		{
			Type = (UInt32)reader.ReadVarInt();
			GenId = (UInt16)reader.ReadVarShort();
		}
	}
}
