using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ShortcutBarAddRequestMessage
	{
		public Byte BarType { get; set; }
		public Shortcut Shortcut { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(BarType);
			Shortcut.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			BarType = reader.ReadByte();
			Shortcut = new Shortcut();
			Shortcut.Deserialize(reader);
		}
	}
}
