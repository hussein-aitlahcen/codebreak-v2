using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyRefuseInvitationMessage : AbstractPartyMessage
	{
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}
	}
}
