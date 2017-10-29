using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatSmileyExtraPackListMessage
	{
		public Byte[] PackIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < PackIds.Length; i++)
			{
				writer.WriteByte(PackIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PackIds = new Byte[reader.ReadShort()];
			for (var i = 0; i < PackIds.Length; i++)
			{
				PackIds[i] = reader.ReadByte();
			}
		}
	}
}
