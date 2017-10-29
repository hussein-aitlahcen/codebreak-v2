using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MapFightStartPositionsUpdateMessage
	{
		public Double MapId { get; set; }
		public FightStartingPositions FightStartPositions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(MapId);
			FightStartPositions.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			MapId = reader.ReadDouble();
			FightStartPositions = new FightStartingPositions();
			FightStartPositions.Deserialize(reader);
		}
	}
}
