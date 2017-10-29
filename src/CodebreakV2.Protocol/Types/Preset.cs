using System;
namespace CodebreakV2.Protocol.Types
{
	public class Preset
	{
		public Byte PresetId { get; set; }
		public Byte SymbolId { get; set; }
		public Boolean Mount { get; set; }
		public PresetItem[] Objects { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(PresetId);
			writer.WriteByte(SymbolId);
			writer.WriteBoolean(Mount);
			for (var i = 0; i < Objects.Length; i++)
			{
				Objects[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PresetId = reader.ReadByte();
			SymbolId = reader.ReadByte();
			Mount = reader.ReadBoolean();
			Objects = new PresetItem[reader.ReadShort()];
			for (var i = 0; i < Objects.Length; i++)
			{
				(Objects[i] = new PresetItem()).Deserialize(reader);
			}
		}
	}
}
