using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AchievementDetailedListMessage
	{
		public Achievement[] StartedAchievements { get; set; }
		public Achievement[] FinishedAchievements { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < StartedAchievements.Length; i++)
			{
				StartedAchievements[i].Serialize(writer);
			}
			for (var i = 0; i < FinishedAchievements.Length; i++)
			{
				FinishedAchievements[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			StartedAchievements = new Achievement[reader.ReadShort()];
			for (var i = 0; i < StartedAchievements.Length; i++)
			{
				(StartedAchievements[i] = new Achievement()).Deserialize(reader);
			}
			FinishedAchievements = new Achievement[reader.ReadShort()];
			for (var i = 0; i < FinishedAchievements.Length; i++)
			{
				(FinishedAchievements[i] = new Achievement()).Deserialize(reader);
			}
		}
	}
}
