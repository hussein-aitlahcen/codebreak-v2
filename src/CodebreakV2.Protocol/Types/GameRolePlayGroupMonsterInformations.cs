using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayGroupMonsterInformations : GameRolePlayActorInformations
	{
		public GroupMonsterStaticInformations StaticInfos { get; set; }
		public Double CreationTime { get; set; }
		public UInt32 AgeBonusRate { get; set; }
		public SByte LootShare { get; set; }
		public SByte AlignmentSide { get; set; }
		public Boolean KeyRingBonus { get; set; }
		public Boolean HasHardcoreDrop { get; set; }
		public Boolean HasAVARewardToken { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			UInt32 wrappedBoolean = 0;
			StaticInfos.Serialize(writer);
			writer.WriteDouble(CreationTime);
			writer.WriteInt((Int32)AgeBonusRate);
			writer.WriteByte((Byte)LootShare);
			writer.WriteByte((Byte)AlignmentSide);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, KeyRingBonus);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, HasHardcoreDrop);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 2, HasAVARewardToken);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			UInt32 wrappedBoolean = 0;
			StaticInfos = new GroupMonsterStaticInformations();
			StaticInfos.Deserialize(reader);
			CreationTime = reader.ReadDouble();
			AgeBonusRate = (UInt32)reader.ReadInt();
			LootShare = (SByte)reader.ReadByte();
			AlignmentSide = (SByte)reader.ReadByte();
			wrappedBoolean = (UInt32)reader.ReadByte();
			KeyRingBonus = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			HasHardcoreDrop = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			HasAVARewardToken = BooleanByteWrapper.GetFlag(wrappedBoolean, 2);
		}
	}
}
