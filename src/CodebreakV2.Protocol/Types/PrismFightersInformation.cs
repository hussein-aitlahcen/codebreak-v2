using System;
namespace CodebreakV2.Protocol.Types
{
	public class PrismFightersInformation
	{
		public UInt16 SubAreaId { get; set; }
		public ProtectedEntityWaitingForHelpInfo WaitingForHelpInfo { get; set; }
		public CharacterMinimalPlusLookInformations[] AllyCharactersInformations { get; set; }
		public CharacterMinimalPlusLookInformations[] EnemyCharactersInformations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SubAreaId);
			WaitingForHelpInfo.Serialize(writer);
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
			SubAreaId = (UInt16)reader.ReadVarShort();
			WaitingForHelpInfo = new ProtectedEntityWaitingForHelpInfo();
			WaitingForHelpInfo.Deserialize(reader);
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
