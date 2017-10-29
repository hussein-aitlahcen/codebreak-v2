using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CheckFileRequestMessage
	{
		public String Filename { get; set; }
		public Byte Type { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Filename);
			writer.WriteByte(Type);
		}
		public void Deserialize(IDataReader reader)
		{
			Filename = reader.ReadUTF();
			Type = reader.ReadByte();
		}
	}
}
