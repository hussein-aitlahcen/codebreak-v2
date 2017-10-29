using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseGenericItemAddedMessage
	{
		public UInt16 ObjGenericId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ObjGenericId);
		}
		public void Deserialize(IDataReader reader)
		{
			ObjGenericId = (UInt16)reader.ReadVarShort();
		}
	}
}
