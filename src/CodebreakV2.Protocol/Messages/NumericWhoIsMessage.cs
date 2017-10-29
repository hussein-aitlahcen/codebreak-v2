using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NumericWhoIsMessage
	{
		public Int64 PlayerId { get; set; }
		public UInt32 AccountId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(PlayerId);
			writer.WriteInt((Int32)AccountId);
		}
		public void Deserialize(IDataReader reader)
		{
			PlayerId = reader.ReadVarLong();
			AccountId = (UInt32)reader.ReadInt();
		}
	}
}
