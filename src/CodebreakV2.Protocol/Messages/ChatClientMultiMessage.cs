using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatClientMultiMessage : ChatAbstractClientMessage
	{
		public Byte Channel { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Channel);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Channel = reader.ReadByte();
		}
	}
}
