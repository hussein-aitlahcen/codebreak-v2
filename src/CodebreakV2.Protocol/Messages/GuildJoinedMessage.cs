using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildJoinedMessage
	{
		public GuildInformations GuildInfo { get; set; }
		public UInt32 MemberRights { get; set; }
		public void Serialize(IDataWriter writer)
		{
			GuildInfo.Serialize(writer);
			writer.WriteVarInt((Int32)MemberRights);
		}
		public void Deserialize(IDataReader reader)
		{
			GuildInfo = new GuildInformations();
			GuildInfo.Deserialize(reader);
			MemberRights = (UInt32)reader.ReadVarInt();
		}
	}
}
