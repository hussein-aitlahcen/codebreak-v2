using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InviteInHavenBagClosedMessage
	{
		public CharacterMinimalInformations HostInformations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			HostInformations.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			HostInformations = new CharacterMinimalInformations();
			HostInformations.Deserialize(reader);
		}
	}
}
