using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InviteInHavenBagOfferMessage
	{
		public CharacterMinimalInformations HostInformations { get; set; }
		public Int32 TimeLeftBeforeCancel { get; set; }
		public void Serialize(IDataWriter writer)
		{
			HostInformations.Serialize(writer);
			writer.WriteVarInt(TimeLeftBeforeCancel);
		}
		public void Deserialize(IDataReader reader)
		{
			HostInformations = new CharacterMinimalInformations();
			HostInformations.Deserialize(reader);
			TimeLeftBeforeCancel = reader.ReadVarInt();
		}
	}
}
