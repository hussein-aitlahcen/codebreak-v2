using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildModificationEmblemValidMessage
	{
		public GuildEmblem GuildEmblem { get; set; }
		public void Serialize(IDataWriter writer)
		{
			GuildEmblem.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			GuildEmblem = new GuildEmblem();
			GuildEmblem.Deserialize(reader);
		}
	}
}
