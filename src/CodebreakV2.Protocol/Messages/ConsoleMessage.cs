using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ConsoleMessage
	{
		public Byte Type { get; set; }
		public String Content { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Type);
			writer.WriteUTF(Content);
		}
		public void Deserialize(IDataReader reader)
		{
			Type = reader.ReadByte();
			Content = reader.ReadUTF();
		}
	}
}
