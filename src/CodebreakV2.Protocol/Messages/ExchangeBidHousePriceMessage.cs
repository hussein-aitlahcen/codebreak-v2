using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHousePriceMessage
	{
		public UInt16 GenId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)GenId);
		}
		public void Deserialize(IDataReader reader)
		{
			GenId = (UInt16)reader.ReadVarShort();
		}
	}
}
