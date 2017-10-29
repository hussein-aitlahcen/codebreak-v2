using System;
namespace CodebreakV2.Protocol.Types
{
	public class GuildMember : CharacterMinimalInformations
	{
		public SByte Breed { get; set; }
		public Boolean Sex { get; set; }
		public UInt16 Rank { get; set; }
		public Int64 GivenExperience { get; set; }
		public Byte ExperienceGivenPercent { get; set; }
		public UInt32 Rights { get; set; }
		public Byte Connected { get; set; }
		public SByte AlignmentSide { get; set; }
		public UInt16 HoursSinceLastConnection { get; set; }
		public UInt16 MoodSmileyId { get; set; }
		public UInt32 AccountId { get; set; }
		public Int32 AchievementPoints { get; set; }
		public PlayerStatus Status { get; set; }
		public Boolean HavenBagShared { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			UInt32 wrappedBoolean = 0;
			writer.WriteByte((Byte)Breed);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Sex);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarShort((Int16)Rank);
			writer.WriteVarLong(GivenExperience);
			writer.WriteByte(ExperienceGivenPercent);
			writer.WriteVarInt((Int32)Rights);
			writer.WriteByte(Connected);
			writer.WriteByte((Byte)AlignmentSide);
			writer.WriteShort((Int16)HoursSinceLastConnection);
			writer.WriteVarShort((Int16)MoodSmileyId);
			writer.WriteInt((Int32)AccountId);
			writer.WriteInt(AchievementPoints);
			Status.Serialize(writer);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, HavenBagShared);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			UInt32 wrappedBoolean = 0;
			Breed = (SByte)reader.ReadByte();
			wrappedBoolean = (UInt32)reader.ReadByte();
			Sex = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			Rank = (UInt16)reader.ReadVarShort();
			GivenExperience = reader.ReadVarLong();
			ExperienceGivenPercent = reader.ReadByte();
			Rights = (UInt32)reader.ReadVarInt();
			Connected = reader.ReadByte();
			AlignmentSide = (SByte)reader.ReadByte();
			HoursSinceLastConnection = (UInt16)reader.ReadShort();
			MoodSmileyId = (UInt16)reader.ReadVarShort();
			AccountId = (UInt32)reader.ReadInt();
			AchievementPoints = reader.ReadInt();
			Status = new PlayerStatus();
			Status.Deserialize(reader);
			wrappedBoolean = (UInt32)reader.ReadByte();
			HavenBagShared = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
		}
	}
}
