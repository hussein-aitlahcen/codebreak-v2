using System;
namespace CodebreakV2.Protocol.Types
{
	public class HouseGuildedInformations : HouseInstanceInformations
	{
		public GuildInformations GuildInfo { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			GuildInfo.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			GuildInfo = new GuildInformations();
			GuildInfo.Deserialize(reader);
		}
	}
}
