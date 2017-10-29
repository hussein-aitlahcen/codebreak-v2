using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryPresetItemUpdateMessage
	{
		public Byte PresetId { get; set; }
		public PresetItem PresetItem { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(PresetId);
			PresetItem.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			PresetId = reader.ReadByte();
			PresetItem = new PresetItem();
			PresetItem.Deserialize(reader);
		}
	}
}
