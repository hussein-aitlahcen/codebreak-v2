using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeCrafterJobLevelupMessage
	{
		public Byte CrafterJobLevel { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(CrafterJobLevel);
		}
		public void Deserialize(IDataReader reader)
		{
			CrafterJobLevel = reader.ReadByte();
		}
	}
}
