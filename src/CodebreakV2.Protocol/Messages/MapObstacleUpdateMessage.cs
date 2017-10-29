using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MapObstacleUpdateMessage
	{
		public MapObstacle[] Obstacles { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Obstacles.Length; i++)
			{
				Obstacles[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Obstacles = new MapObstacle[reader.ReadShort()];
			for (var i = 0; i < Obstacles.Length; i++)
			{
				(Obstacles[i] = new MapObstacle()).Deserialize(reader);
			}
		}
	}
}
