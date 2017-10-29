using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryPresetUpdateMessage
	{
		public Preset Preset { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Preset.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Preset = new Preset();
			Preset.Deserialize(reader);
		}
	}
}
