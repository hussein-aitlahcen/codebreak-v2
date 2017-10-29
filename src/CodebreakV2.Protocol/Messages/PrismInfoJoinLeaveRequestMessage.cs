using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismInfoJoinLeaveRequestMessage
	{
		public Boolean Join { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Join);
		}
		public void Deserialize(IDataReader reader)
		{
			Join = reader.ReadBoolean();
		}
	}
}
