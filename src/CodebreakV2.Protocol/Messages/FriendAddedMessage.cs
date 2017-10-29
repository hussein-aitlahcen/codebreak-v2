using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class FriendAddedMessage
	{
		public FriendInformations FriendAdded { get; set; }
		public void Serialize(IDataWriter writer)
		{
			FriendAdded.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			FriendAdded = new FriendInformations();
			FriendAdded.Deserialize(reader);
		}
	}
}
