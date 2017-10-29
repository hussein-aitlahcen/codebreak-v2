using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildModificationNameValidMessage
	{
		public String GuildName { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(GuildName);
		}
		public void Deserialize(IDataReader reader)
		{
			GuildName = reader.ReadUTF();
		}
	}
}
