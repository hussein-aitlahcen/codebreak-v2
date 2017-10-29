using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatClientPrivateMessage : ChatAbstractClientMessage
	{
		public String Receiver { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(Receiver);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Receiver = reader.ReadUTF();
		}
	}
}
