using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildKickRequestMessage
	{
		public Int64 KickedId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(KickedId);
		}
		public void Deserialize(IDataReader reader)
		{
			KickedId = reader.ReadVarLong();
		}
	}
}
