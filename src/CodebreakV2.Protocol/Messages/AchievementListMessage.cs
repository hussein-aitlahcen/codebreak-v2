using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AchievementListMessage
	{
		public UInt16[] FinishedAchievementsIds { get; set; }
		public AchievementRewardable[] RewardableAchievements { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < FinishedAchievementsIds.Length; i++)
			{
				writer.WriteVarShort((Int16)FinishedAchievementsIds[i]);
			}
			for (var i = 0; i < RewardableAchievements.Length; i++)
			{
				RewardableAchievements[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			FinishedAchievementsIds = new UInt16[reader.ReadShort()];
			for (var i = 0; i < FinishedAchievementsIds.Length; i++)
			{
				FinishedAchievementsIds[i] = (UInt16)reader.ReadVarShort();
			}
			RewardableAchievements = new AchievementRewardable[reader.ReadShort()];
			for (var i = 0; i < RewardableAchievements.Length; i++)
			{
				(RewardableAchievements[i] = new AchievementRewardable()).Deserialize(reader);
			}
		}
	}
}
