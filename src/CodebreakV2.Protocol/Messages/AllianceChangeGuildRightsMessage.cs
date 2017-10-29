using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceChangeGuildRightsMessage
	{
		public UInt32 GuildId { get; set; }
		public Byte Rights { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)GuildId);
			writer.WriteByte(Rights);
		}
		public void Deserialize(IDataReader reader)
		{
			GuildId = (UInt32)reader.ReadVarInt();
			Rights = reader.ReadByte();
		}
	}
}
