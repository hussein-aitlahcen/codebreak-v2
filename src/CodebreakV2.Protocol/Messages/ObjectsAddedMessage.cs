using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectsAddedMessage
	{
		public ObjectItem[] Object { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Object.Length; i++)
			{
				Object[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Object = new ObjectItem[reader.ReadShort()];
			for (var i = 0; i < Object.Length; i++)
			{
				(Object[i] = new ObjectItem()).Deserialize(reader);
			}
		}
	}
}
