using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ServersListMessage
	{
		public GameServerInformations[] Servers { get; set; }
		public UInt16 AlreadyConnectedToServerId { get; set; }
		public Boolean CanCreateNewCharacter { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Servers.Length; i++)
			{
				Servers[i].Serialize(writer);
			}
			writer.WriteVarShort((Int16)AlreadyConnectedToServerId);
			writer.WriteBoolean(CanCreateNewCharacter);
		}
		public void Deserialize(IDataReader reader)
		{
			Servers = new GameServerInformations[reader.ReadShort()];
			for (var i = 0; i < Servers.Length; i++)
			{
				(Servers[i] = new GameServerInformations()).Deserialize(reader);
			}
			AlreadyConnectedToServerId = (UInt16)reader.ReadVarShort();
			CanCreateNewCharacter = reader.ReadBoolean();
		}
	}
}
