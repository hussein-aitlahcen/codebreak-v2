using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterStatsListMessage
	{
		public CharacterCharacteristicsInformations Stats { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Stats.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Stats = new CharacterCharacteristicsInformations();
			Stats.Deserialize(reader);
		}
	}
}
