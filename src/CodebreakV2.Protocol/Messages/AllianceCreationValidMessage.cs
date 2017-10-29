using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceCreationValidMessage
	{
		public String AllianceName { get; set; }
		public String AllianceTag { get; set; }
		public GuildEmblem AllianceEmblem { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(AllianceName);
			writer.WriteUTF(AllianceTag);
			AllianceEmblem.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			AllianceName = reader.ReadUTF();
			AllianceTag = reader.ReadUTF();
			AllianceEmblem = new GuildEmblem();
			AllianceEmblem.Deserialize(reader);
		}
	}
}
