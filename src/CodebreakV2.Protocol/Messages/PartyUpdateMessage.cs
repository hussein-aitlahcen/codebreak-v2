using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyUpdateMessage : AbstractPartyEventMessage
	{
		public PartyMemberInformations MemberInformations { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			MemberInformations.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MemberInformations = new PartyMemberInformations();
			MemberInformations.Deserialize(reader);
		}
	}
}
