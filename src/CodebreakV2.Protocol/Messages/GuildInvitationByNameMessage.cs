using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildInvitationByNameMessage
	{
		public String Name { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Name);
		}
		public void Deserialize(IDataReader reader)
		{
			Name = reader.ReadUTF();
		}
	}
}
