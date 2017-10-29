using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildInvitationAnswerMessage
	{
		public Boolean Accept { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Accept);
		}
		public void Deserialize(IDataReader reader)
		{
			Accept = reader.ReadBoolean();
		}
	}
}
