using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceModificationEmblemValidMessage
	{
		public GuildEmblem Alliancemblem { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Alliancemblem.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Alliancemblem = new GuildEmblem();
			Alliancemblem.Deserialize(reader);
		}
	}
}
