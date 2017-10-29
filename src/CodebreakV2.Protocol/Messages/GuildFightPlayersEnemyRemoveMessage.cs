using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildFightPlayersEnemyRemoveMessage
	{
		public Double FightId { get; set; }
		public Int64 PlayerId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(FightId);
			writer.WriteVarLong(PlayerId);
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = reader.ReadDouble();
			PlayerId = reader.ReadVarLong();
		}
	}
}
