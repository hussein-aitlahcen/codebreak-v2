using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MapComplementaryInformationsDataMessage
	{
		public UInt16 SubAreaId { get; set; }
		public Double MapId { get; set; }
		public HouseInformations[] Houses { get; set; }
		public GameRolePlayActorInformations[] Actors { get; set; }
		public InteractiveElement[] InteractiveElements { get; set; }
		public StatedElement[] StatedElements { get; set; }
		public MapObstacle[] Obstacles { get; set; }
		public FightCommonInformations[] Fights { get; set; }
		public Boolean HasAggressiveMonsters { get; set; }
		public FightStartingPositions FightStartPositions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteDouble(MapId);
			for (var i = 0; i < Houses.Length; i++)
			{
				Houses[i].Serialize(writer);
			}
			for (var i = 0; i < Actors.Length; i++)
			{
				Actors[i].Serialize(writer);
			}
			for (var i = 0; i < InteractiveElements.Length; i++)
			{
				InteractiveElements[i].Serialize(writer);
			}
			for (var i = 0; i < StatedElements.Length; i++)
			{
				StatedElements[i].Serialize(writer);
			}
			for (var i = 0; i < Obstacles.Length; i++)
			{
				Obstacles[i].Serialize(writer);
			}
			for (var i = 0; i < Fights.Length; i++)
			{
				Fights[i].Serialize(writer);
			}
			writer.WriteBoolean(HasAggressiveMonsters);
			FightStartPositions.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			SubAreaId = (UInt16)reader.ReadVarShort();
			MapId = reader.ReadDouble();
			Houses = new HouseInformations[reader.ReadShort()];
			for (var i = 0; i < Houses.Length; i++)
			{
				(Houses[i] = new HouseInformations()).Deserialize(reader);
			}
			Actors = new GameRolePlayActorInformations[reader.ReadShort()];
			for (var i = 0; i < Actors.Length; i++)
			{
				(Actors[i] = new GameRolePlayActorInformations()).Deserialize(reader);
			}
			InteractiveElements = new InteractiveElement[reader.ReadShort()];
			for (var i = 0; i < InteractiveElements.Length; i++)
			{
				(InteractiveElements[i] = new InteractiveElement()).Deserialize(reader);
			}
			StatedElements = new StatedElement[reader.ReadShort()];
			for (var i = 0; i < StatedElements.Length; i++)
			{
				(StatedElements[i] = new StatedElement()).Deserialize(reader);
			}
			Obstacles = new MapObstacle[reader.ReadShort()];
			for (var i = 0; i < Obstacles.Length; i++)
			{
				(Obstacles[i] = new MapObstacle()).Deserialize(reader);
			}
			Fights = new FightCommonInformations[reader.ReadShort()];
			for (var i = 0; i < Fights.Length; i++)
			{
				(Fights[i] = new FightCommonInformations()).Deserialize(reader);
			}
			HasAggressiveMonsters = reader.ReadBoolean();
			FightStartPositions = new FightStartingPositions();
			FightStartPositions.Deserialize(reader);
		}
	}
}
