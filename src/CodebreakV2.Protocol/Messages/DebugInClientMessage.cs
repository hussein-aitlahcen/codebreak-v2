using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DebugInClientMessage
	{
		public Byte Level { get; set; }
		public String Message { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Level);
			writer.WriteUTF(Message);
		}
		public void Deserialize(IDataReader reader)
		{
			Level = reader.ReadByte();
			Message = reader.ReadUTF();
		}
	}
}
