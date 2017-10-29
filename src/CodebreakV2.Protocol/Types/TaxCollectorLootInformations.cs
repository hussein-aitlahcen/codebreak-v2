using System;
namespace CodebreakV2.Protocol.Types
{
	public class TaxCollectorLootInformations : TaxCollectorComplementaryInformations
	{
		public Int64 Kamas { get; set; }
		public Int64 Experience { get; set; }
		public UInt32 Pods { get; set; }
		public Int64 ItemsValue { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(Kamas);
			writer.WriteVarLong(Experience);
			writer.WriteVarInt((Int32)Pods);
			writer.WriteVarLong(ItemsValue);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Kamas = reader.ReadVarLong();
			Experience = reader.ReadVarLong();
			Pods = (UInt32)reader.ReadVarInt();
			ItemsValue = reader.ReadVarLong();
		}
	}
}
