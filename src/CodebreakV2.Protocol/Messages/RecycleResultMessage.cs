using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class RecycleResultMessage
	{
		public UInt32 NuggetsForPrism { get; set; }
		public UInt32 NuggetsForPlayer { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)NuggetsForPrism);
			writer.WriteVarInt((Int32)NuggetsForPlayer);
		}
		public void Deserialize(IDataReader reader)
		{
			NuggetsForPrism = (UInt32)reader.ReadVarInt();
			NuggetsForPlayer = (UInt32)reader.ReadVarInt();
		}
	}
}
