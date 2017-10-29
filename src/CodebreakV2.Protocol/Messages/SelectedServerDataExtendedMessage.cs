using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SelectedServerDataExtendedMessage : SelectedServerDataMessage
	{
		public GameServerInformations[] Servers { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < Servers.Length; i++)
			{
				Servers[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Servers = new GameServerInformations[reader.ReadShort()];
			for (var i = 0; i < Servers.Length; i++)
			{
				(Servers[i] = new GameServerInformations()).Deserialize(reader);
			}
		}
	}
}
