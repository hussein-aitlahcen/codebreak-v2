using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AccessoryPreviewErrorMessage
	{
		public Byte Error { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Error);
		}
		public void Deserialize(IDataReader reader)
		{
			Error = reader.ReadByte();
		}
	}
}
