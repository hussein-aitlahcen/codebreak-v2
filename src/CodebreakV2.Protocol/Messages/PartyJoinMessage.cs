using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyJoinMessage : AbstractPartyMessage
	{
		public Byte PartyType { get; set; }
		public Int64 PartyLeaderId { get; set; }
		public Byte MaxParticipants { get; set; }
		public PartyMemberInformations[] Members { get; set; }
		public PartyGuestInformations[] Guests { get; set; }
		public Boolean Restricted { get; set; }
		public String PartyName { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(PartyType);
			writer.WriteVarLong(PartyLeaderId);
			writer.WriteByte(MaxParticipants);
			for (var i = 0; i < Members.Length; i++)
			{
				Members[i].Serialize(writer);
			}
			for (var i = 0; i < Guests.Length; i++)
			{
				Guests[i].Serialize(writer);
			}
			writer.WriteBoolean(Restricted);
			writer.WriteUTF(PartyName);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PartyType = reader.ReadByte();
			PartyLeaderId = reader.ReadVarLong();
			MaxParticipants = reader.ReadByte();
			Members = new PartyMemberInformations[reader.ReadShort()];
			for (var i = 0; i < Members.Length; i++)
			{
				(Members[i] = new PartyMemberInformations()).Deserialize(reader);
			}
			Guests = new PartyGuestInformations[reader.ReadShort()];
			for (var i = 0; i < Guests.Length; i++)
			{
				(Guests[i] = new PartyGuestInformations()).Deserialize(reader);
			}
			Restricted = reader.ReadBoolean();
			PartyName = reader.ReadUTF();
		}
	}
}
