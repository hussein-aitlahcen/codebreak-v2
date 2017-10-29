using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ShortcutBarRemoveRequestMessage
	{
		public Byte BarType { get; set; }
		public Byte Slot { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(BarType);
			writer.WriteByte(Slot);
		}
		public void Deserialize(IDataReader reader)
		{
			BarType = reader.ReadByte();
			Slot = reader.ReadByte();
		}
	}
}
