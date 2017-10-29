using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ShortcutBarSwapRequestMessage
	{
		public Byte BarType { get; set; }
		public Byte FirstSlot { get; set; }
		public Byte SecondSlot { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(BarType);
			writer.WriteByte(FirstSlot);
			writer.WriteByte(SecondSlot);
		}
		public void Deserialize(IDataReader reader)
		{
			BarType = reader.ReadByte();
			FirstSlot = reader.ReadByte();
			SecondSlot = reader.ReadByte();
		}
	}
}
