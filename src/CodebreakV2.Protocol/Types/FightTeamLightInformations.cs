using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTeamLightInformations : AbstractFightTeamInformations
	{
		public Byte TeamMembersCount { get; set; }
		public UInt32 MeanLevel { get; set; }
		public Boolean HasFriend { get; set; }
		public Boolean HasGuildMember { get; set; }
		public Boolean HasAllianceMember { get; set; }
		public Boolean HasGroupMember { get; set; }
		public Boolean HasMyTaxCollector { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			UInt32 wrappedBoolean = 0;
			writer.WriteByte(TeamMembersCount);
			writer.WriteVarInt((Int32)MeanLevel);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, HasFriend);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, HasGuildMember);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 2, HasAllianceMember);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 3, HasGroupMember);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 4, HasMyTaxCollector);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			UInt32 wrappedBoolean = 0;
			TeamMembersCount = reader.ReadByte();
			MeanLevel = (UInt32)reader.ReadVarInt();
			wrappedBoolean = (UInt32)reader.ReadByte();
			HasFriend = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			HasGuildMember = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			HasAllianceMember = BooleanByteWrapper.GetFlag(wrappedBoolean, 2);
			HasGroupMember = BooleanByteWrapper.GetFlag(wrappedBoolean, 3);
			HasMyTaxCollector = BooleanByteWrapper.GetFlag(wrappedBoolean, 4);
		}
	}
}
