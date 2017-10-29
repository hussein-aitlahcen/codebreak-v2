using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectAddedMessage
	{
		public ObjectItem Object { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Object.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Object = new ObjectItem();
			Object.Deserialize(reader);
		}
	}
}
