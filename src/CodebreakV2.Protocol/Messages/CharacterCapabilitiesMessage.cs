using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterCapabilitiesMessage
	{
		public UInt32 GuildEmblemSymbolCategories { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)GuildEmblemSymbolCategories);
		}
		public void Deserialize(IDataReader reader)
		{
			GuildEmblemSymbolCategories = (UInt32)reader.ReadVarInt();
		}
	}
}
