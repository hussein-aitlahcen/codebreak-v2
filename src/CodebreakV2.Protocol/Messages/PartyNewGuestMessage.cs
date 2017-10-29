using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyNewGuestMessage : AbstractPartyEventMessage
	{
		public PartyGuestInformations Guest { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			Guest.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Guest = new PartyGuestInformations();
			Guest.Deserialize(reader);
		}
	}
}
