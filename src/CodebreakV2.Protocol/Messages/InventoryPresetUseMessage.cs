using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryPresetUseMessage
	{
		public Byte PresetId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(PresetId);
		}
		public void Deserialize(IDataReader reader)
		{
			PresetId = reader.ReadByte();
		}
	}
}
