using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IdolsPresetUseResultMessage
	{
		public Byte PresetId { get; set; }
		public Byte Code { get; set; }
		public UInt16[] MissingIdols { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(PresetId);
			writer.WriteByte(Code);
			for (var i = 0; i < MissingIdols.Length; i++)
			{
				writer.WriteVarShort((Int16)MissingIdols[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PresetId = reader.ReadByte();
			Code = reader.ReadByte();
			MissingIdols = new UInt16[reader.ReadShort()];
			for (var i = 0; i < MissingIdols.Length; i++)
			{
				MissingIdols[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
