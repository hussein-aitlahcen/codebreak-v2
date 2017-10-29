using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ServerStatusUpdateMessage
	{
		public GameServerInformations Server { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Server.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Server = new GameServerInformations();
			Server.Deserialize(reader);
		}
	}
}
