using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayAttackMonsterRequestMessage
	{
		public Double MonsterGroupId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(MonsterGroupId);
		}
		public void Deserialize(IDataReader reader)
		{
			MonsterGroupId = reader.ReadDouble();
		}
	}
}
