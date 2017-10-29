using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class RefreshCharacterStatsMessage
	{
		public Double FighterId { get; set; }
		public GameFightMinimalStats Stats { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(FighterId);
			Stats.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			FighterId = reader.ReadDouble();
			Stats = new GameFightMinimalStats();
			Stats.Deserialize(reader);
		}
	}
}
