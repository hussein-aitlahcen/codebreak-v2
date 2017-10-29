using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InteractiveElementUpdatedMessage
	{
		public InteractiveElement InteractiveElement { get; set; }
		public void Serialize(IDataWriter writer)
		{
			InteractiveElement.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			InteractiveElement = new InteractiveElement();
			InteractiveElement.Deserialize(reader);
		}
	}
}
