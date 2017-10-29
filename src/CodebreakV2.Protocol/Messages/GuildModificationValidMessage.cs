using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildModificationValidMessage
	{
		public String GuildName { get; set; }
		public GuildEmblem GuildEmblem { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(GuildName);
			GuildEmblem.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			GuildName = reader.ReadUTF();
			GuildEmblem = new GuildEmblem();
			GuildEmblem.Deserialize(reader);
		}
	}
}
