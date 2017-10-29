using System;
namespace CodebreakV2.Protocol.Types
{
	public class ShortcutObjectIdolsPreset : ShortcutObject
	{
		public Byte PresetId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(PresetId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PresetId = reader.ReadByte();
		}
	}
}
