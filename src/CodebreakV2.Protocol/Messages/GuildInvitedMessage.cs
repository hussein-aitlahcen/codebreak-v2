using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildInvitedMessage
	{
		public Int64 RecruterId { get; set; }
		public String RecruterName { get; set; }
		public BasicGuildInformations GuildInfo { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(RecruterId);
			writer.WriteUTF(RecruterName);
			GuildInfo.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			RecruterId = reader.ReadVarLong();
			RecruterName = reader.ReadUTF();
			GuildInfo = new BasicGuildInformations();
			GuildInfo.Deserialize(reader);
		}
	}
}
