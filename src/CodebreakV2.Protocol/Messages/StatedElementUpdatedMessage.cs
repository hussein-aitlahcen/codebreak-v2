using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StatedElementUpdatedMessage
	{
		public StatedElement StatedElement { get; set; }
		public void Serialize(IDataWriter writer)
		{
			StatedElement.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			StatedElement = new StatedElement();
			StatedElement.Deserialize(reader);
		}
	}
}
