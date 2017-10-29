using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyCancelInvitationMessage : AbstractPartyMessage
	{
		public Int64 GuestId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(GuestId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			GuestId = reader.ReadVarLong();
		}
	}
}
