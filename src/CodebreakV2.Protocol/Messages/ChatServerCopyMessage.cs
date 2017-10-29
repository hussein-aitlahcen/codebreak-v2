using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatServerCopyMessage : ChatAbstractServerMessage
	{
		public Int64 ReceiverId { get; set; }
		public String ReceiverName { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(ReceiverId);
			writer.WriteUTF(ReceiverName);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ReceiverId = reader.ReadVarLong();
			ReceiverName = reader.ReadUTF();
		}
	}
}
