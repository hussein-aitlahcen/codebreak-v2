using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ShortcutBarContentMessage
	{
		public Byte BarType { get; set; }
		public Shortcut[] Shortcuts { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(BarType);
			for (var i = 0; i < Shortcuts.Length; i++)
			{
				Shortcuts[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			BarType = reader.ReadByte();
			Shortcuts = new Shortcut[reader.ReadShort()];
			for (var i = 0; i < Shortcuts.Length; i++)
			{
				(Shortcuts[i] = new Shortcut()).Deserialize(reader);
			}
		}
	}
}
