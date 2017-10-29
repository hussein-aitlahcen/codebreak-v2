using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatMessageReportMessage
	{
		public String SenderName { get; set; }
		public String Content { get; set; }
		public UInt32 Timestamp { get; set; }
		public Byte Channel { get; set; }
		public String Fingerprint { get; set; }
		public Byte Reason { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(SenderName);
			writer.WriteUTF(Content);
			writer.WriteInt((Int32)Timestamp);
			writer.WriteByte(Channel);
			writer.WriteUTF(Fingerprint);
			writer.WriteByte(Reason);
		}
		public void Deserialize(IDataReader reader)
		{
			SenderName = reader.ReadUTF();
			Content = reader.ReadUTF();
			Timestamp = (UInt32)reader.ReadInt();
			Channel = reader.ReadByte();
			Fingerprint = reader.ReadUTF();
			Reason = reader.ReadByte();
		}
	}
}
