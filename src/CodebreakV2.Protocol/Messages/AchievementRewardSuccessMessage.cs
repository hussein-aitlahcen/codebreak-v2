using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AchievementRewardSuccessMessage
	{
		public Int16 AchievementId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort(AchievementId);
		}
		public void Deserialize(IDataReader reader)
		{
			AchievementId = reader.ReadShort();
		}
	}
}
