using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class IgnoredDeleteRequestMessage
	{
		public UInt32 AccountId { get; set; }
		public Boolean Session { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)AccountId);
			writer.WriteBoolean(Session);
		}
		public void Deserialize(IDataReader reader)
		{
			AccountId = (UInt32)reader.ReadInt();
			Session = reader.ReadBoolean();
		}
	}
}
