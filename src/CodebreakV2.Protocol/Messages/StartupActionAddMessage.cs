using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StartupActionAddMessage
	{
		public StartupActionAddObject NewAction { get; set; }
		public void Serialize(IDataWriter writer)
		{
			NewAction.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			NewAction = new StartupActionAddObject();
			NewAction.Deserialize(reader);
		}
	}
}
