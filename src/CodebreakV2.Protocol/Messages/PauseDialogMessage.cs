using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PauseDialogMessage
	{
		public Byte DialogType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(DialogType);
		}
		public void Deserialize(IDataReader reader)
		{
			DialogType = reader.ReadByte();
		}
	}
}
