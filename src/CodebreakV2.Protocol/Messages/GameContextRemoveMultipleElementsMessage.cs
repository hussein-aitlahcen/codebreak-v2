using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameContextRemoveMultipleElementsMessage
	{
		public Double[] ElementsIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < ElementsIds.Length; i++)
			{
				writer.WriteDouble(ElementsIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ElementsIds = new Double[reader.ReadShort()];
			for (var i = 0; i < ElementsIds.Length; i++)
			{
				ElementsIds[i] = reader.ReadDouble();
			}
		}
	}
}
