using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildInfosUpgradeMessage
	{
		public Byte MaxTaxCollectorsCount { get; set; }
		public Byte TaxCollectorsCount { get; set; }
		public UInt16 TaxCollectorLifePoints { get; set; }
		public UInt16 TaxCollectorDamagesBonuses { get; set; }
		public UInt16 TaxCollectorPods { get; set; }
		public UInt16 TaxCollectorProspecting { get; set; }
		public UInt16 TaxCollectorWisdom { get; set; }
		public UInt16 BoostPoints { get; set; }
		public UInt16[] SpellId { get; set; }
		public Int16[] SpellLevel { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(MaxTaxCollectorsCount);
			writer.WriteByte(TaxCollectorsCount);
			writer.WriteVarShort((Int16)TaxCollectorLifePoints);
			writer.WriteVarShort((Int16)TaxCollectorDamagesBonuses);
			writer.WriteVarShort((Int16)TaxCollectorPods);
			writer.WriteVarShort((Int16)TaxCollectorProspecting);
			writer.WriteVarShort((Int16)TaxCollectorWisdom);
			writer.WriteVarShort((Int16)BoostPoints);
			for (var i = 0; i < SpellId.Length; i++)
			{
				writer.WriteVarShort((Int16)SpellId[i]);
			}
			for (var i = 0; i < SpellLevel.Length; i++)
			{
				writer.WriteShort(SpellLevel[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			MaxTaxCollectorsCount = reader.ReadByte();
			TaxCollectorsCount = reader.ReadByte();
			TaxCollectorLifePoints = (UInt16)reader.ReadVarShort();
			TaxCollectorDamagesBonuses = (UInt16)reader.ReadVarShort();
			TaxCollectorPods = (UInt16)reader.ReadVarShort();
			TaxCollectorProspecting = (UInt16)reader.ReadVarShort();
			TaxCollectorWisdom = (UInt16)reader.ReadVarShort();
			BoostPoints = (UInt16)reader.ReadVarShort();
			SpellId = new UInt16[reader.ReadShort()];
			for (var i = 0; i < SpellId.Length; i++)
			{
				SpellId[i] = (UInt16)reader.ReadVarShort();
			}
			SpellLevel = new Int16[reader.ReadShort()];
			for (var i = 0; i < SpellLevel.Length; i++)
			{
				SpellLevel[i] = reader.ReadShort();
			}
		}
	}
}
