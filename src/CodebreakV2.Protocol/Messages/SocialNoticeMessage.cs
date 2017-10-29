using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SocialNoticeMessage
	{
		public String Content { get; set; }
		public UInt32 Timestamp { get; set; }
		public Int64 MemberId { get; set; }
		public String MemberName { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Content);
			writer.WriteInt((Int32)Timestamp);
			writer.WriteVarLong(MemberId);
			writer.WriteUTF(MemberName);
		}
		public void Deserialize(IDataReader reader)
		{
			Content = reader.ReadUTF();
			Timestamp = (UInt32)reader.ReadInt();
			MemberId = reader.ReadVarLong();
			MemberName = reader.ReadUTF();
		}
	}
}
