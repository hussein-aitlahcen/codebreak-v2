using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PopupWarningMessage
	{
		public Byte LockDuration { get; set; }
		public String Author { get; set; }
		public String Content { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(LockDuration);
			writer.WriteUTF(Author);
			writer.WriteUTF(Content);
		}
		public void Deserialize(IDataReader reader)
		{
			LockDuration = reader.ReadByte();
			Author = reader.ReadUTF();
			Content = reader.ReadUTF();
		}
	}
}
