using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChatServerCopyWithObjectMessage : ChatServerCopyMessage
	{
		public ObjectItem[] Objects { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < Objects.Length; i++)
			{
				Objects[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Objects = new ObjectItem[reader.ReadShort()];
			for (var i = 0; i < Objects.Length; i++)
			{
				(Objects[i] = new ObjectItem()).Deserialize(reader);
			}
		}
	}
}
