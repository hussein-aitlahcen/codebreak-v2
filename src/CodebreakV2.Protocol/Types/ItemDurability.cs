using System;
namespace CodebreakV2.Protocol.Types
{
	public class ItemDurability
	{
		public Int16 Durability { get; set; }
		public Int16 DurabilityMax { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort(Durability);
			writer.WriteShort(DurabilityMax);
		}
		public void Deserialize(IDataReader reader)
		{
			Durability = reader.ReadShort();
			DurabilityMax = reader.ReadShort();
		}
	}
}
