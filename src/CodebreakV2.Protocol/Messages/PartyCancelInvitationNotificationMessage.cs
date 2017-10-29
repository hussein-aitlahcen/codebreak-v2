using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
	{
		public Int64 CancelerId { get; set; }
		public Int64 GuestId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(CancelerId);
			writer.WriteVarLong(GuestId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CancelerId = reader.ReadVarLong();
			GuestId = reader.ReadVarLong();
		}
	}
}
