using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SelectedServerRefusedMessage
	{
		public UInt16 ServerId { get; set; }
		public Byte Error { get; set; }
		public Byte ServerStatus { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ServerId);
			writer.WriteByte(Error);
			writer.WriteByte(ServerStatus);
		}
		public void Deserialize(IDataReader reader)
		{
			ServerId = (UInt16)reader.ReadVarShort();
			Error = reader.ReadByte();
			ServerStatus = reader.ReadByte();
		}
	}
}
