using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class EmoteListMessage
	{
		public Byte[] EmoteIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < EmoteIds.Length; i++)
			{
				writer.WriteByte(EmoteIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			EmoteIds = new Byte[reader.ReadShort()];
			for (var i = 0; i < EmoteIds.Length; i++)
			{
				EmoteIds[i] = reader.ReadByte();
			}
		}
	}
}
