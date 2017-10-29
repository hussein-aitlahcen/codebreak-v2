using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StatedMapUpdateMessage
	{
		public StatedElement[] StatedElements { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < StatedElements.Length; i++)
			{
				StatedElements[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			StatedElements = new StatedElement[reader.ReadShort()];
			for (var i = 0; i < StatedElements.Length; i++)
			{
				(StatedElements[i] = new StatedElement()).Deserialize(reader);
			}
		}
	}
}
