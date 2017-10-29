using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyInvitationDetailsMessage : AbstractPartyMessage
	{
		public Byte PartyType { get; set; }
		public String PartyName { get; set; }
		public Int64 FromId { get; set; }
		public String FromName { get; set; }
		public Int64 LeaderId { get; set; }
		public PartyInvitationMemberInformations[] Members { get; set; }
		public PartyGuestInformations[] Guests { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(PartyType);
			writer.WriteUTF(PartyName);
			writer.WriteVarLong(FromId);
			writer.WriteUTF(FromName);
			writer.WriteVarLong(LeaderId);
			for (var i = 0; i < Members.Length; i++)
			{
				Members[i].Serialize(writer);
			}
			for (var i = 0; i < Guests.Length; i++)
			{
				Guests[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PartyType = reader.ReadByte();
			PartyName = reader.ReadUTF();
			FromId = reader.ReadVarLong();
			FromName = reader.ReadUTF();
			LeaderId = reader.ReadVarLong();
			Members = new PartyInvitationMemberInformations[reader.ReadShort()];
			for (var i = 0; i < Members.Length; i++)
			{
				(Members[i] = new PartyInvitationMemberInformations()).Deserialize(reader);
			}
			Guests = new PartyGuestInformations[reader.ReadShort()];
			for (var i = 0; i < Guests.Length; i++)
			{
				(Guests[i] = new PartyGuestInformations()).Deserialize(reader);
			}
		}
	}
}
