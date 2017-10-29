using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class NpcDialogQuestionMessage
	{
		public UInt32 MessageId { get; set; }
		public String[] DialogParams { get; set; }
		public UInt32[] VisibleReplies { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)MessageId);
			for (var i = 0; i < DialogParams.Length; i++)
			{
				writer.WriteUTF(DialogParams[i]);
			}
			for (var i = 0; i < VisibleReplies.Length; i++)
			{
				writer.WriteVarInt((Int32)VisibleReplies[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			MessageId = (UInt32)reader.ReadVarInt();
			DialogParams = new String[reader.ReadShort()];
			for (var i = 0; i < DialogParams.Length; i++)
			{
				DialogParams[i] = reader.ReadUTF();
			}
			VisibleReplies = new UInt32[reader.ReadShort()];
			for (var i = 0; i < VisibleReplies.Length; i++)
			{
				VisibleReplies[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
