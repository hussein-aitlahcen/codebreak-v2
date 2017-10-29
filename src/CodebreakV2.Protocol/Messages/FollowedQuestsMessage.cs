using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class FollowedQuestsMessage
	{
		public QuestActiveDetailedInformations[] Quests { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Quests.Length; i++)
			{
				Quests[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Quests = new QuestActiveDetailedInformations[reader.ReadShort()];
			for (var i = 0; i < Quests.Length; i++)
			{
				(Quests[i] = new QuestActiveDetailedInformations()).Deserialize(reader);
			}
		}
	}
}
