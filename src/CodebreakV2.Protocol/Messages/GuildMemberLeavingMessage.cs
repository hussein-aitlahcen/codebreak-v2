using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildMemberLeavingMessage
	{
		public Boolean Kicked { get; set; }
		public Int64 MemberId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Kicked);
			writer.WriteVarLong(MemberId);
		}
		public void Deserialize(IDataReader reader)
		{
			Kicked = reader.ReadBoolean();
			MemberId = reader.ReadVarLong();
		}
	}
}
