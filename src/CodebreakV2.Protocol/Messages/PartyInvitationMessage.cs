using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyInvitationMessage : AbstractPartyMessage
	{
		public Byte PartyType { get; set; }
		public String PartyName { get; set; }
		public Byte MaxParticipants { get; set; }
		public Int64 FromId { get; set; }
		public String FromName { get; set; }
		public Int64 ToId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(PartyType);
			writer.WriteUTF(PartyName);
			writer.WriteByte(MaxParticipants);
			writer.WriteVarLong(FromId);
			writer.WriteUTF(FromName);
			writer.WriteVarLong(ToId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			PartyType = reader.ReadByte();
			PartyName = reader.ReadUTF();
			MaxParticipants = reader.ReadByte();
			FromId = reader.ReadVarLong();
			FromName = reader.ReadUTF();
			ToId = reader.ReadVarLong();
		}
	}
}
