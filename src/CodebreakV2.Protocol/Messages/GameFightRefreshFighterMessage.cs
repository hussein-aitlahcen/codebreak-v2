using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightRefreshFighterMessage
	{
		public GameContextActorInformations Informations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Informations.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Informations = new GameContextActorInformations();
			Informations.Deserialize(reader);
		}
	}
}
