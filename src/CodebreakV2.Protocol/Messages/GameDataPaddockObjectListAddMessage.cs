using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameDataPaddockObjectListAddMessage
	{
		public PaddockItem[] PaddockItemDescription { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < PaddockItemDescription.Length; i++)
			{
				PaddockItemDescription[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PaddockItemDescription = new PaddockItem[reader.ReadShort()];
			for (var i = 0; i < PaddockItemDescription.Length; i++)
			{
				(PaddockItemDescription[i] = new PaddockItem()).Deserialize(reader);
			}
		}
	}
}
