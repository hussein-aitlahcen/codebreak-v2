using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatAbstractServerMessage
	{
		public Byte Channel { get; set; }
		public String Content { get; set; }
		public UInt32 Timestamp { get; set; }
		public String Fingerprint { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Channel);
			writer.WriteUTF(Content);
			writer.WriteInt((Int32)Timestamp);
			writer.WriteUTF(Fingerprint);
		}
		public void Deserialize(IDataReader reader)
		{
			Channel = reader.ReadByte();
			Content = reader.ReadUTF();
			Timestamp = (UInt32)reader.ReadInt();
			Fingerprint = reader.ReadUTF();
		}
	}
}
