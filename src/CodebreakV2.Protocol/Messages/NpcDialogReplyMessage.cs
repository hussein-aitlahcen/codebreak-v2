using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NpcDialogReplyMessage
	{
		public UInt32 ReplyId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ReplyId);
		}
		public void Deserialize(IDataReader reader)
		{
			ReplyId = (UInt32)reader.ReadVarInt();
		}
	}
}
