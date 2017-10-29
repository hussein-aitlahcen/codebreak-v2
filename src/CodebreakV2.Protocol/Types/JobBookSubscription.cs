using System;
namespace CodebreakV2.Protocol.Types
{
	public class JobBookSubscription
	{
		public Byte JobId { get; set; }
		public Boolean Subscribed { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(JobId);
			writer.WriteBoolean(Subscribed);
		}
		public void Deserialize(IDataReader reader)
		{
			JobId = reader.ReadByte();
			Subscribed = reader.ReadBoolean();
		}
	}
}
