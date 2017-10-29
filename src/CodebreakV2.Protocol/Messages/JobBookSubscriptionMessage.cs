using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class JobBookSubscriptionMessage
	{
		public JobBookSubscription[] Subscriptions { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Subscriptions.Length; i++)
			{
				Subscriptions[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Subscriptions = new JobBookSubscription[reader.ReadShort()];
			for (var i = 0; i < Subscriptions.Length; i++)
			{
				(Subscriptions[i] = new JobBookSubscription()).Deserialize(reader);
			}
		}
	}
}
