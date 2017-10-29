using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class FriendsListMessage
	{
		public FriendInformations[] FriendsList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < FriendsList.Length; i++)
			{
				FriendsList[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			FriendsList = new FriendInformations[reader.ReadShort()];
			for (var i = 0; i < FriendsList.Length; i++)
			{
				(FriendsList[i] = new FriendInformations()).Deserialize(reader);
			}
		}
	}
}
