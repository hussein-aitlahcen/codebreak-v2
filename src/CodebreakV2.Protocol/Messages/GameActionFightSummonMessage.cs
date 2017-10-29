using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightSummonMessage : AbstractGameActionMessage
	{
		public GameFightFighterInformations[] Summons { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < Summons.Length; i++)
			{
				Summons[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Summons = new GameFightFighterInformations[reader.ReadShort()];
			for (var i = 0; i < Summons.Length; i++)
			{
				(Summons[i] = new GameFightFighterInformations()).Deserialize(reader);
			}
		}
	}
}
