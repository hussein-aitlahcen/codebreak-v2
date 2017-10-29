using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildVersatileInfoListMessage
	{
		public GuildVersatileInformations[] Guilds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Guilds.Length; i++)
			{
				Guilds[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Guilds = new GuildVersatileInformations[reader.ReadShort()];
			for (var i = 0; i < Guilds.Length; i++)
			{
				(Guilds[i] = new GuildVersatileInformations()).Deserialize(reader);
			}
		}
	}
}
