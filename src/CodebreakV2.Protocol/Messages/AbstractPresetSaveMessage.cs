using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AbstractPresetSaveMessage
	{
		public Byte PresetId { get; set; }
		public Byte SymbolId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(PresetId);
			writer.WriteByte(SymbolId);
		}
		public void Deserialize(IDataReader reader)
		{
			PresetId = reader.ReadByte();
			SymbolId = reader.ReadByte();
		}
	}
}
