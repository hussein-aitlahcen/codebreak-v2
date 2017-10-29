using System;
namespace CodebreakV2.Protocol.Types
{
	public class IdolsPreset
	{
		public Byte PresetId { get; set; }
		public Byte SymbolId { get; set; }
		public UInt16[] IdolId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(PresetId);
			writer.WriteByte(SymbolId);
			for (var i = 0; i < IdolId.Length; i++)
			{
				writer.WriteVarShort((Int16)IdolId[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PresetId = reader.ReadByte();
			SymbolId = reader.ReadByte();
			IdolId = new UInt16[reader.ReadShort()];
			for (var i = 0; i < IdolId.Length; i++)
			{
				IdolId[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
