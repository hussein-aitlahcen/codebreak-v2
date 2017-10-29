using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightStartingMessage
	{
		public Byte FightType { get; set; }
		public Double AttackerId { get; set; }
		public Double DefenderId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(FightType);
			writer.WriteDouble(AttackerId);
			writer.WriteDouble(DefenderId);
		}
		public void Deserialize(IDataReader reader)
		{
			FightType = reader.ReadByte();
			AttackerId = reader.ReadDouble();
			DefenderId = reader.ReadDouble();
		}
	}
}
