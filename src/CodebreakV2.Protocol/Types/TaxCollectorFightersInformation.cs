using System;
namespace CodebreakV2.Protocol.Types
{
	public class TaxCollectorFightersInformation
	{
		public Double CollectorId { get; set; }
		public CharacterMinimalPlusLookInformations[] AllyCharactersInformations { get; set; }
		public CharacterMinimalPlusLookInformations[] EnemyCharactersInformations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(CollectorId);
			for (var i = 0; i < AllyCharactersInformations.Length; i++)
			{
				AllyCharactersInformations[i].Serialize(writer);
			}
			for (var i = 0; i < EnemyCharactersInformations.Length; i++)
			{
				EnemyCharactersInformations[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			CollectorId = reader.ReadDouble();
			AllyCharactersInformations = new CharacterMinimalPlusLookInformations[reader.ReadShort()];
			for (var i = 0; i < AllyCharactersInformations.Length; i++)
			{
				(AllyCharactersInformations[i] = new CharacterMinimalPlusLookInformations()).Deserialize(reader);
			}
			EnemyCharactersInformations = new CharacterMinimalPlusLookInformations[reader.ReadShort()];
			for (var i = 0; i < EnemyCharactersInformations.Length; i++)
			{
				(EnemyCharactersInformations[i] = new CharacterMinimalPlusLookInformations()).Deserialize(reader);
			}
		}
	}
}
