using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartsListMessage
	{
		public ContentPart[] Parts { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Parts.Length; i++)
			{
				Parts[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Parts = new ContentPart[reader.ReadShort()];
			for (var i = 0; i < Parts.Length; i++)
			{
				(Parts[i] = new ContentPart()).Deserialize(reader);
			}
		}
	}
}
