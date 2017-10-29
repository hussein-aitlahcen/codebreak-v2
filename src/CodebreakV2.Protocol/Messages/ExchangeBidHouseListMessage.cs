using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseListMessage
	{
		public UInt16 Id { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Id);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = (UInt16)reader.ReadVarShort();
		}
	}
}
