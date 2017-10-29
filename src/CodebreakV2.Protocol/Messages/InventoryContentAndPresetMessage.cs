using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryContentAndPresetMessage : InventoryContentMessage
	{
		public Preset[] Presets { get; set; }
		public IdolsPreset[] IdolsPresets { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < Presets.Length; i++)
			{
				Presets[i].Serialize(writer);
			}
			for (var i = 0; i < IdolsPresets.Length; i++)
			{
				IdolsPresets[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Presets = new Preset[reader.ReadShort()];
			for (var i = 0; i < Presets.Length; i++)
			{
				(Presets[i] = new Preset()).Deserialize(reader);
			}
			IdolsPresets = new IdolsPreset[reader.ReadShort()];
			for (var i = 0; i < IdolsPresets.Length; i++)
			{
				(IdolsPresets[i] = new IdolsPreset()).Deserialize(reader);
			}
		}
	}
}
