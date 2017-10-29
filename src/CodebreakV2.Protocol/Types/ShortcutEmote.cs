using System;
namespace CodebreakV2.Protocol.Types
{
	public class ShortcutEmote : Shortcut
	{
		public Byte EmoteId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(EmoteId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			EmoteId = reader.ReadByte();
		}
	}
}
