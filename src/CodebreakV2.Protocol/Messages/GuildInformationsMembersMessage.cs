using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildInformationsMembersMessage
	{
		public GuildMember[] Members { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Members.Length; i++)
			{
				Members[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Members = new GuildMember[reader.ReadShort()];
			for (var i = 0; i < Members.Length; i++)
			{
				(Members[i] = new GuildMember()).Deserialize(reader);
			}
		}
	}
}
