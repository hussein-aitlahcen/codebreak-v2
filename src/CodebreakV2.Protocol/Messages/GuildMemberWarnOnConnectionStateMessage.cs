using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildMemberWarnOnConnectionStateMessage
	{
		public Boolean Enable { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Enable);
		}
		public void Deserialize(IDataReader reader)
		{
			Enable = reader.ReadBoolean();
		}
	}
}
