using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class URLOpenMessage
	{
		public Byte UrlId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(UrlId);
		}
		public void Deserialize(IDataReader reader)
		{
			UrlId = reader.ReadByte();
		}
	}
}
