using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class StartupActionsListMessage
	{
		public StartupActionAddObject[] Actions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Actions.Length; i++)
			{
				Actions[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Actions = new StartupActionAddObject[reader.ReadShort()];
			for (var i = 0; i < Actions.Length; i++)
			{
				(Actions[i] = new StartupActionAddObject()).Deserialize(reader);
			}
		}
	}
}
