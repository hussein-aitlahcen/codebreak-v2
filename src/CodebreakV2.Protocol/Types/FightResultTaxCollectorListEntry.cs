using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightResultTaxCollectorListEntry : FightResultFighterListEntry
	{
		public Byte Level { get; set; }
		public BasicGuildInformations GuildInfo { get; set; }
		public Int32 ExperienceForGuild { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(Level);
			GuildInfo.Serialize(writer);
			writer.WriteInt(ExperienceForGuild);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Level = reader.ReadByte();
			GuildInfo = new BasicGuildInformations();
			GuildInfo.Deserialize(reader);
			ExperienceForGuild = reader.ReadInt();
		}
	}
}
