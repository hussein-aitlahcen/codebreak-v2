using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartedMountStockMessage
	{
		public ObjectItem[] ObjectsInfos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				ObjectsInfos[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectsInfos = new ObjectItem[reader.ReadShort()];
			for (var i = 0; i < ObjectsInfos.Length; i++)
			{
				(ObjectsInfos[i] = new ObjectItem()).Deserialize(reader);
			}
		}
	}
}
