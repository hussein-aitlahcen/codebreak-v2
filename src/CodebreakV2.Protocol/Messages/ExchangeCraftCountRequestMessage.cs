using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeCraftCountRequestMessage
	{
		public Int32 Count { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(Count);
		}
		public void Deserialize(IDataReader reader)
		{
			Count = reader.ReadVarInt();
		}
	}
}
