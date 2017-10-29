using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyInvitationCancelledForGuestMessage : AbstractPartyMessage
	{
		public Int64 CancelerId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(CancelerId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CancelerId = reader.ReadVarLong();
		}
	}
}
