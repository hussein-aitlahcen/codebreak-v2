using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InteractiveMapUpdateMessage
	{
		public InteractiveElement[] InteractiveElements { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < InteractiveElements.Length; i++)
			{
				InteractiveElements[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			InteractiveElements = new InteractiveElement[reader.ReadShort()];
			for (var i = 0; i < InteractiveElements.Length; i++)
			{
				(InteractiveElements[i] = new InteractiveElement()).Deserialize(reader);
			}
		}
	}
}
