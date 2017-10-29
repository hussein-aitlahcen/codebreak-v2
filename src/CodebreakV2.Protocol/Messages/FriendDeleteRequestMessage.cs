using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class FriendDeleteRequestMessage
	{
		public UInt32 AccountId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)AccountId);
		}
		public void Deserialize(IDataReader reader)
		{
			AccountId = (UInt32)reader.ReadInt();
		}
	}
}
