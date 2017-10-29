using System;
namespace CodebreakV2.Protocol.Types
{
	public class HumanOptionGuild : HumanOption
	{
		public GuildInformations GuildInformations { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			GuildInformations.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			GuildInformations = new GuildInformations();
			GuildInformations.Deserialize(reader);
		}
	}
}
