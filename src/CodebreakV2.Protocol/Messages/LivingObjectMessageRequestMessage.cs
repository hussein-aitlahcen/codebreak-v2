using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LivingObjectMessageRequestMessage
	{
		public UInt16 MsgId { get; set; }
		public String[] Parameters { get; set; }
		public UInt32 LivingObject { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)MsgId);
			for (var i = 0; i < Parameters.Length; i++)
			{
				writer.WriteUTF(Parameters[i]);
			}
			writer.WriteVarInt((Int32)LivingObject);
		}
		public void Deserialize(IDataReader reader)
		{
			MsgId = (UInt16)reader.ReadVarShort();
			Parameters = new String[reader.ReadShort()];
			for (var i = 0; i < Parameters.Length; i++)
			{
				Parameters[i] = reader.ReadUTF();
			}
			LivingObject = (UInt32)reader.ReadVarInt();
		}
	}
}
