using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightResultExperienceData : FightResultAdditionalData
	{
		public Int64 Experience { get; set; }
		public Boolean ShowExperience { get; set; }
		public Int64 ExperienceLevelFloor { get; set; }
		public Boolean ShowExperienceLevelFloor { get; set; }
		public Int64 ExperienceNextLevelFloor { get; set; }
		public Boolean ShowExperienceNextLevelFloor { get; set; }
		public Int64 ExperienceFightDelta { get; set; }
		public Boolean ShowExperienceFightDelta { get; set; }
		public Int64 ExperienceForGuild { get; set; }
		public Boolean ShowExperienceForGuild { get; set; }
		public Int64 ExperienceForMount { get; set; }
		public Boolean ShowExperienceForMount { get; set; }
		public Boolean IsIncarnationExperience { get; set; }
		public Byte RerollExperienceMul { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			UInt32 wrappedBoolean = 0;
			writer.WriteVarLong(Experience);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, ShowExperience);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarLong(ExperienceLevelFloor);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, ShowExperienceLevelFloor);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarLong(ExperienceNextLevelFloor);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, ShowExperienceNextLevelFloor);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarLong(ExperienceFightDelta);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, ShowExperienceFightDelta);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarLong(ExperienceForGuild);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, ShowExperienceForGuild);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarLong(ExperienceForMount);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, ShowExperienceForMount);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, IsIncarnationExperience);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteByte(RerollExperienceMul);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			UInt32 wrappedBoolean = 0;
			Experience = reader.ReadVarLong();
			wrappedBoolean = (UInt32)reader.ReadByte();
			ShowExperience = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			ExperienceLevelFloor = reader.ReadVarLong();
			wrappedBoolean = (UInt32)reader.ReadByte();
			ShowExperienceLevelFloor = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			ExperienceNextLevelFloor = reader.ReadVarLong();
			wrappedBoolean = (UInt32)reader.ReadByte();
			ShowExperienceNextLevelFloor = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			ExperienceFightDelta = reader.ReadVarLong();
			wrappedBoolean = (UInt32)reader.ReadByte();
			ShowExperienceFightDelta = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			ExperienceForGuild = reader.ReadVarLong();
			wrappedBoolean = (UInt32)reader.ReadByte();
			ShowExperienceForGuild = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			ExperienceForMount = reader.ReadVarLong();
			wrappedBoolean = (UInt32)reader.ReadByte();
			ShowExperienceForMount = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			IsIncarnationExperience = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			RerollExperienceMul = reader.ReadByte();
		}
	}
}
