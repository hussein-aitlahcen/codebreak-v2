using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRefreshMonsterBoostsMessage
	{
		public MonsterBoosts[] MonsterBoosts { get; set; }
		public MonsterBoosts[] FamilyBoosts { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < MonsterBoosts.Length; i++)
			{
				MonsterBoosts[i].Serialize(writer);
			}
			for (var i = 0; i < FamilyBoosts.Length; i++)
			{
				FamilyBoosts[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			MonsterBoosts = new MonsterBoosts[reader.ReadShort()];
			for (var i = 0; i < MonsterBoosts.Length; i++)
			{
				(MonsterBoosts[i] = new MonsterBoosts()).Deserialize(reader);
			}
			FamilyBoosts = new MonsterBoosts[reader.ReadShort()];
			for (var i = 0; i < FamilyBoosts.Length; i++)
			{
				(FamilyBoosts[i] = new MonsterBoosts()).Deserialize(reader);
			}
		}
	}
}
