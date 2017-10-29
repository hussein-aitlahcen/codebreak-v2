using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatServerMessage : ChatAbstractServerMessage
	{
		public Double SenderId { get; set; }
		public String SenderName { get; set; }
		public UInt32 SenderAccountId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(SenderId);
			writer.WriteUTF(SenderName);
			writer.WriteInt((Int32)SenderAccountId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SenderId = reader.ReadDouble();
			SenderName = reader.ReadUTF();
			SenderAccountId = (UInt32)reader.ReadInt();
		}
	}
}
