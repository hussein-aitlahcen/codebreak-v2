using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightSynchronizeMessage
	{
		public GameFightFighterInformations[] Fighters { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Fighters.Length; i++)
			{
				Fighters[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Fighters = new GameFightFighterInformations[reader.ReadShort()];
			for (var i = 0; i < Fighters.Length; i++)
			{
				(Fighters[i] = new GameFightFighterInformations()).Deserialize(reader);
			}
		}
	}
}
