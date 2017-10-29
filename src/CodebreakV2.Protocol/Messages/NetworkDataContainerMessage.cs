using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NetworkDataContainerMessage
	{
		public Byte[] Content { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Content.Length; i++)
			{
				writer.WriteByte(Content[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Content = new Byte[reader.ReadVarInt()];
			for (var i = 0; i < Content.Length; i++)
			{
				Content[i] = reader.ReadByte();
			}
		}
	}
}
