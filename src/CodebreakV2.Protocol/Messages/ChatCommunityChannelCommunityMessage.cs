using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatCommunityChannelCommunityMessage
	{
		public Int16 CommunityId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort(CommunityId);
		}
		public void Deserialize(IDataReader reader)
		{
			CommunityId = reader.ReadShort();
		}
	}
}
