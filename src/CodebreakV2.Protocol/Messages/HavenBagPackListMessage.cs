using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HavenBagPackListMessage
	{
		public SByte[] PackIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < PackIds.Length; i++)
			{
				writer.WriteByte((Byte)PackIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PackIds = new SByte[reader.ReadShort()];
			for (var i = 0; i < PackIds.Length; i++)
			{
				PackIds[i] = (SByte)reader.ReadByte();
			}
		}
	}
}
