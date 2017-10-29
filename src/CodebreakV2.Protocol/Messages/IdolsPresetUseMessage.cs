using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdolsPresetUseMessage
	{
		public Byte PresetId { get; set; }
		public Boolean Party { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(PresetId);
			writer.WriteBoolean(Party);
		}
		public void Deserialize(IDataReader reader)
		{
			PresetId = reader.ReadByte();
			Party = reader.ReadBoolean();
		}
	}
}
