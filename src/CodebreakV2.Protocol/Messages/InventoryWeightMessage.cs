using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InventoryWeightMessage
	{
		public UInt32 Weight { get; set; }
		public UInt32 WeightMax { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)Weight);
			writer.WriteVarInt((Int32)WeightMax);
		}
		public void Deserialize(IDataReader reader)
		{
			Weight = (UInt32)reader.ReadVarInt();
			WeightMax = (UInt32)reader.ReadVarInt();
		}
	}
}
