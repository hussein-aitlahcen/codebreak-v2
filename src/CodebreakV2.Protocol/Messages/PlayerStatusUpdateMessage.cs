using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PlayerStatusUpdateMessage
	{
		public UInt32 AccountId { get; set; }
		public Int64 PlayerId { get; set; }
		public PlayerStatus Status { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)AccountId);
			writer.WriteVarLong(PlayerId);
			Status.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			AccountId = (UInt32)reader.ReadInt();
			PlayerId = reader.ReadVarLong();
			Status = new PlayerStatus();
			Status.Deserialize(reader);
		}
	}
}
