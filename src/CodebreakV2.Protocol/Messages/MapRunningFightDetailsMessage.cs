using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MapRunningFightDetailsMessage
	{
		public UInt32 FightId { get; set; }
		public GameFightFighterLightInformations[] Attackers { get; set; }
		public GameFightFighterLightInformations[] Defenders { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)FightId);
			for (var i = 0; i < Attackers.Length; i++)
			{
				Attackers[i].Serialize(writer);
			}
			for (var i = 0; i < Defenders.Length; i++)
			{
				Defenders[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			FightId = (UInt32)reader.ReadInt();
			Attackers = new GameFightFighterLightInformations[reader.ReadShort()];
			for (var i = 0; i < Attackers.Length; i++)
			{
				(Attackers[i] = new GameFightFighterLightInformations()).Deserialize(reader);
			}
			Defenders = new GameFightFighterLightInformations[reader.ReadShort()];
			for (var i = 0; i < Defenders.Length; i++)
			{
				(Defenders[i] = new GameFightFighterLightInformations()).Deserialize(reader);
			}
		}
	}
}
