using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildFactsErrorMessage
	{
		public UInt32 GuildId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)GuildId);
		}
		public void Deserialize(IDataReader reader)
		{
			GuildId = (UInt32)reader.ReadVarInt();
		}
	}
}
