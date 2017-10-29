using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildMemberOnlineStatusMessage
	{
		public Int64 MemberId { get; set; }
		public Boolean Online { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(MemberId);
			writer.WriteBoolean(Online);
		}
		public void Deserialize(IDataReader reader)
		{
			MemberId = reader.ReadVarLong();
			Online = reader.ReadBoolean();
		}
	}
}
