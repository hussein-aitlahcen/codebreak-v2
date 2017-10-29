using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareRewardWonMessage
	{
		public DareReward Reward { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Reward.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Reward = new DareReward();
			Reward.Deserialize(reader);
		}
	}
}
