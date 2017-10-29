using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterExperienceGainMessage
	{
		public Int64 ExperienceCharacter { get; set; }
		public Int64 ExperienceMount { get; set; }
		public Int64 ExperienceGuild { get; set; }
		public Int64 ExperienceIncarnation { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(ExperienceCharacter);
			writer.WriteVarLong(ExperienceMount);
			writer.WriteVarLong(ExperienceGuild);
			writer.WriteVarLong(ExperienceIncarnation);
		}
		public void Deserialize(IDataReader reader)
		{
			ExperienceCharacter = reader.ReadVarLong();
			ExperienceMount = reader.ReadVarLong();
			ExperienceGuild = reader.ReadVarLong();
			ExperienceIncarnation = reader.ReadVarLong();
		}
	}
}
