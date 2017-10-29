using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SystemMessageDisplayMessage
	{
		public Boolean HangUp { get; set; }
		public UInt16 MsgId { get; set; }
		public String[] Parameters { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(HangUp);
			writer.WriteVarShort((Int16)MsgId);
			for (var i = 0; i < Parameters.Length; i++)
			{
				writer.WriteUTF(Parameters[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			HangUp = reader.ReadBoolean();
			MsgId = (UInt16)reader.ReadVarShort();
			Parameters = new String[reader.ReadShort()];
			for (var i = 0; i < Parameters.Length; i++)
			{
				Parameters[i] = reader.ReadUTF();
			}
		}
	}
}
