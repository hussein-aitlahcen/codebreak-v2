using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AuthenticationTicketMessage
	{
		public String Lang { get; set; }
		public String Ticket { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Lang);
			writer.WriteUTF(Ticket);
		}
		public void Deserialize(IDataReader reader)
		{
			Lang = reader.ReadUTF();
			Ticket = reader.ReadUTF();
		}
	}
}
