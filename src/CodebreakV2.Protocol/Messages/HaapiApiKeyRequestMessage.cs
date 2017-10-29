using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HaapiApiKeyRequestMessage
	{
		public Byte KeyType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(KeyType);
		}
		public void Deserialize(IDataReader reader)
		{
			KeyType = reader.ReadByte();
		}
	}
}
