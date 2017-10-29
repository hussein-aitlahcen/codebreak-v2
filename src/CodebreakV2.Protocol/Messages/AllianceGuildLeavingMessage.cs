using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceGuildLeavingMessage
	{
		public Boolean Kicked { get; set; }
		public UInt32 GuildId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Kicked);
			writer.WriteVarInt((Int32)GuildId);
		}
		public void Deserialize(IDataReader reader)
		{
			Kicked = reader.ReadBoolean();
			GuildId = (UInt32)reader.ReadVarInt();
		}
	}
}
