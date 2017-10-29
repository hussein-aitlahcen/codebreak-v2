using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildListMessage
	{
		public GuildInformations[] Guilds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Guilds.Length; i++)
			{
				Guilds[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Guilds = new GuildInformations[reader.ReadShort()];
			for (var i = 0; i < Guilds.Length; i++)
			{
				(Guilds[i] = new GuildInformations()).Deserialize(reader);
			}
		}
	}
}
