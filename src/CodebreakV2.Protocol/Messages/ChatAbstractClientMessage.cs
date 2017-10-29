using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatAbstractClientMessage
	{
		public String Content { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Content);
		}
		public void Deserialize(IDataReader reader)
		{
			Content = reader.ReadUTF();
		}
	}
}
