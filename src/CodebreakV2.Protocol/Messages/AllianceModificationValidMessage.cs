using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceModificationValidMessage
	{
		public String AllianceName { get; set; }
		public String AllianceTag { get; set; }
		public GuildEmblem Alliancemblem { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(AllianceName);
			writer.WriteUTF(AllianceTag);
			Alliancemblem.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			AllianceName = reader.ReadUTF();
			AllianceTag = reader.ReadUTF();
			Alliancemblem = new GuildEmblem();
			Alliancemblem.Deserialize(reader);
		}
	}
}
