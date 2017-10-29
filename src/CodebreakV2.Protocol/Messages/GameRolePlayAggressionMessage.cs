using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayAggressionMessage
	{
		public Int64 AttackerId { get; set; }
		public Int64 DefenderId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(AttackerId);
			writer.WriteVarLong(DefenderId);
		}
		public void Deserialize(IDataReader reader)
		{
			AttackerId = reader.ReadVarLong();
			DefenderId = reader.ReadVarLong();
		}
	}
}
