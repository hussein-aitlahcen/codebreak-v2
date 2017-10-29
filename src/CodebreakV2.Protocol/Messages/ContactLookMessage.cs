using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ContactLookMessage
	{
		public UInt32 RequestId { get; set; }
		public String PlayerName { get; set; }
		public Int64 PlayerId { get; set; }
		public EntityLook Look { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)RequestId);
			writer.WriteUTF(PlayerName);
			writer.WriteVarLong(PlayerId);
			Look.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			RequestId = (UInt32)reader.ReadVarInt();
			PlayerName = reader.ReadUTF();
			PlayerId = reader.ReadVarLong();
			Look = new EntityLook();
			Look.Deserialize(reader);
		}
	}
}
