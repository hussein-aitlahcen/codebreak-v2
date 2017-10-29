using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayShowMultipleActorsMessage
	{
		public GameRolePlayActorInformations[] InformationsList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < InformationsList.Length; i++)
			{
				InformationsList[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			InformationsList = new GameRolePlayActorInformations[reader.ReadShort()];
			for (var i = 0; i < InformationsList.Length; i++)
			{
				(InformationsList[i] = new GameRolePlayActorInformations()).Deserialize(reader);
			}
		}
	}
}
