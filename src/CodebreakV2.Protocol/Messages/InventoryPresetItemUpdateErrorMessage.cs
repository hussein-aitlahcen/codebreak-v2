using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryPresetItemUpdateErrorMessage
	{
		public Byte Code { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Code);
		}
		public void Deserialize(IDataReader reader)
		{
			Code = reader.ReadByte();
		}
	}
}
