using System;
namespace CodebreakV2.Protocol.Types
{
	public class AllianceInformations : BasicNamedAllianceInformations
	{
		public GuildEmblem AllianceEmblem { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			AllianceEmblem.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			AllianceEmblem = new GuildEmblem();
			AllianceEmblem.Deserialize(reader);
		}
	}
}
