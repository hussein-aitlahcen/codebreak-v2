using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeCraftResultMessage
	{
		public Byte CraftResult { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(CraftResult);
		}
		public void Deserialize(IDataReader reader)
		{
			CraftResult = reader.ReadByte();
		}
	}
}
