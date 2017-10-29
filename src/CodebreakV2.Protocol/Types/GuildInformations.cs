using System;
namespace CodebreakV2.Protocol.Types
{
	public class GuildInformations : BasicGuildInformations
	{
		public GuildEmblem GuildEmblem { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			GuildEmblem.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			GuildEmblem = new GuildEmblem();
			GuildEmblem.Deserialize(reader);
		}
	}
}
