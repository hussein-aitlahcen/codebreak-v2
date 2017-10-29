using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class FriendUpdateMessage
	{
		public FriendInformations FriendUpdated { get; set; }
		public void Serialize(IDataWriter writer)
		{
			FriendUpdated.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			FriendUpdated = new FriendInformations();
			FriendUpdated.Deserialize(reader);
		}
	}
}
