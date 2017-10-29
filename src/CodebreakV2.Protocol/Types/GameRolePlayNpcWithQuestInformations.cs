using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayNpcWithQuestInformations : GameRolePlayNpcInformations
	{
		public GameRolePlayNpcQuestFlag QuestFlag { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			QuestFlag.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			QuestFlag = new GameRolePlayNpcQuestFlag();
			QuestFlag.Deserialize(reader);
		}
	}
}
