using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightJoinRequestMessage
	{
		public Double FighterId { get; set; }
		public Int32 FightId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(FighterId);
			writer.WriteInt(FightId);
		}
		public void Deserialize(IDataReader reader)
		{
			FighterId = reader.ReadDouble();
			FightId = reader.ReadInt();
		}
	}
}
