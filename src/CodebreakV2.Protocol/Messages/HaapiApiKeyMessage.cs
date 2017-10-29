using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HaapiApiKeyMessage
	{
		public Byte ReturnType { get; set; }
		public Byte KeyType { get; set; }
		public String Token { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(ReturnType);
			writer.WriteByte(KeyType);
			writer.WriteUTF(Token);
		}
		public void Deserialize(IDataReader reader)
		{
			ReturnType = reader.ReadByte();
			KeyType = reader.ReadByte();
			Token = reader.ReadUTF();
		}
	}
}
