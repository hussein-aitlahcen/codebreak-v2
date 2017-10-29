using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChangeHavenBagRoomRequestMessage
	{
		public Byte RoomId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(RoomId);
		}
		public void Deserialize(IDataReader reader)
		{
			RoomId = reader.ReadByte();
		}
	}
}
