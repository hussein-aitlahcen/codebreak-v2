using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MoodSmileyUpdateMessage
	{
		public UInt32 AccountId { get; set; }
		public Int64 PlayerId { get; set; }
		public UInt16 SmileyId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)AccountId);
			writer.WriteVarLong(PlayerId);
			writer.WriteVarShort((Int16)SmileyId);
		}
		public void Deserialize(IDataReader reader)
		{
			AccountId = (UInt32)reader.ReadInt();
			PlayerId = reader.ReadVarLong();
			SmileyId = (UInt16)reader.ReadVarShort();
		}
	}
}
