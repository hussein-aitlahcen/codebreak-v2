using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InviteInHavenBagMessage
	{
		public CharacterMinimalInformations GuestInformations { get; set; }
		public Boolean Accept { get; set; }
		public void Serialize(IDataWriter writer)
		{
			GuestInformations.Serialize(writer);
			writer.WriteBoolean(Accept);
		}
		public void Deserialize(IDataReader reader)
		{
			GuestInformations = new CharacterMinimalInformations();
			GuestInformations.Deserialize(reader);
			Accept = reader.ReadBoolean();
		}
	}
}
