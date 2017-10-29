using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StorageObjectsUpdateMessage
	{
		public ObjectItem[] ObjectList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ObjectList.Length; i++)
			{
				ObjectList[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectList = new ObjectItem[reader.ReadShort()];
			for (var i = 0; i < ObjectList.Length; i++)
			{
				(ObjectList[i] = new ObjectItem()).Deserialize(reader);
			}
		}
	}
}
