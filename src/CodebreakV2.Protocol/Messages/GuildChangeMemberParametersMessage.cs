using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildChangeMemberParametersMessage
	{
		public Int64 MemberId { get; set; }
		public UInt16 Rank { get; set; }
		public Byte ExperienceGivenPercent { get; set; }
		public UInt32 Rights { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(MemberId);
			writer.WriteVarShort((Int16)Rank);
			writer.WriteByte(ExperienceGivenPercent);
			writer.WriteVarInt((Int32)Rights);
		}
		public void Deserialize(IDataReader reader)
		{
			MemberId = reader.ReadVarLong();
			Rank = (UInt16)reader.ReadVarShort();
			ExperienceGivenPercent = reader.ReadByte();
			Rights = (UInt32)reader.ReadVarInt();
		}
	}
}
