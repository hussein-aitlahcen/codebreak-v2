using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SubscriptionLimitationMessage
	{
		public Byte Reason { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Reason);
		}
		public void Deserialize(IDataReader reader)
		{
			Reason = reader.ReadByte();
		}
	}
}
