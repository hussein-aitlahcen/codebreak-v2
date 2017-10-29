using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AbstractPresetSaveResultMessage
	{
		public Byte PresetId { get; set; }
		public Byte Code { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(PresetId);
			writer.WriteByte(Code);
		}
		public void Deserialize(IDataReader reader)
		{
			PresetId = reader.ReadByte();
			Code = reader.ReadByte();
		}
	}
}
