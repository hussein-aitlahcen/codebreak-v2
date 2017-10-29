using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildInformationsMemberUpdateMessage
	{
		public GuildMember Member { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Member.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Member = new GuildMember();
			Member.Deserialize(reader);
		}
	}
}
