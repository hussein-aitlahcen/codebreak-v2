using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PartyMemberInFightMessage : AbstractPartyMessage
	{
		public Byte Reason { get; set; }
		public Int64 MemberId { get; set; }
		public UInt32 MemberAccountId { get; set; }
		public String MemberName { get; set; }
		public Int32 FightId { get; set; }
		public MapCoordinatesExtended FightMap { get; set; }
		public Int16 TimeBeforeFightStart { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Reason);
			writer.WriteVarLong(MemberId);
			writer.WriteInt((Int32)MemberAccountId);
			writer.WriteUTF(MemberName);
			writer.WriteInt(FightId);
			FightMap.Serialize(writer);
			writer.WriteVarShort(TimeBeforeFightStart);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Reason = reader.ReadByte();
			MemberId = reader.ReadVarLong();
			MemberAccountId = (UInt32)reader.ReadInt();
			MemberName = reader.ReadUTF();
			FightId = reader.ReadInt();
			FightMap = new MapCoordinatesExtended();
			FightMap.Deserialize(reader);
			TimeBeforeFightStart = reader.ReadVarShort();
		}
	}
}
