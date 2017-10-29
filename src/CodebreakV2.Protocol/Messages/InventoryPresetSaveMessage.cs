using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryPresetSaveMessage : AbstractPresetSaveMessage
	{
		public Boolean SaveEquipment { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(SaveEquipment);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SaveEquipment = reader.ReadBoolean();
		}
	}
}
