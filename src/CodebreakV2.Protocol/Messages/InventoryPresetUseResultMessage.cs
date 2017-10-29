using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryPresetUseResultMessage
	{
		public Byte PresetId { get; set; }
		public Byte Code { get; set; }
		public Byte[] UnlinkedPosition { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(PresetId);
			writer.WriteByte(Code);
			for (var i = 0; i < UnlinkedPosition.Length; i++)
			{
				writer.WriteByte(UnlinkedPosition[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PresetId = reader.ReadByte();
			Code = reader.ReadByte();
			UnlinkedPosition = new Byte[reader.ReadShort()];
			for (var i = 0; i < UnlinkedPosition.Length; i++)
			{
				UnlinkedPosition[i] = reader.ReadByte();
			}
		}
	}
}
