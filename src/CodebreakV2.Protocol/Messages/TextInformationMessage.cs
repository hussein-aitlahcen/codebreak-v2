using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TextInformationMessage
	{
		public Byte MsgType { get; set; }
		public UInt16 MsgId { get; set; }
		public String[] Parameters { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(MsgType);
			writer.WriteVarShort((Int16)MsgId);
			for (var i = 0; i < Parameters.Length; i++)
			{
				writer.WriteUTF(Parameters[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			MsgType = reader.ReadByte();
			MsgId = (UInt16)reader.ReadVarShort();
			Parameters = new String[reader.ReadShort()];
			for (var i = 0; i < Parameters.Length; i++)
			{
				Parameters[i] = reader.ReadUTF();
			}
		}
	}
}
