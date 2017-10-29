using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareRewardsListMessage
	{
		public DareReward[] Rewards { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Rewards.Length; i++)
			{
				Rewards[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Rewards = new DareReward[reader.ReadShort()];
			for (var i = 0; i < Rewards.Length; i++)
			{
				(Rewards[i] = new DareReward()).Deserialize(reader);
			}
		}
	}
}
