using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CheckFileMessage
	{
		public String FilenameHash { get; set; }
		public Byte Type { get; set; }
		public String Value { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(FilenameHash);
			writer.WriteByte(Type);
			writer.WriteUTF(Value);
		}
		public void Deserialize(IDataReader reader)
		{
			FilenameHash = reader.ReadUTF();
			Type = reader.ReadByte();
			Value = reader.ReadUTF();
		}
	}
}
