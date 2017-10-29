using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ReloginTokenStatusMessage
	{
		public Boolean ValidToken { get; set; }
		public SByte[] Ticket { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(ValidToken);
			for (var i = 0; i < Ticket.Length; i++)
			{
				writer.WriteByte((Byte)Ticket[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ValidToken = reader.ReadBoolean();
			Ticket = new SByte[reader.ReadVarInt()];
			for (var i = 0; i < Ticket.Length; i++)
			{
				Ticket[i] = (SByte)reader.ReadByte();
			}
		}
	}
}
