using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionBasicMessage
	{
		public UInt16 MaxPods { get; set; }
		public UInt16 Prospecting { get; set; }
		public UInt16 Wisdom { get; set; }
		public Byte TaxCollectorsCount { get; set; }
		public Int32 TaxCollectorAttack { get; set; }
		public Int64 Kamas { get; set; }
		public Int64 Experience { get; set; }
		public UInt32 Pods { get; set; }
		public Int64 ItemsValue { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)MaxPods);
			writer.WriteVarShort((Int16)Prospecting);
			writer.WriteVarShort((Int16)Wisdom);
			writer.WriteByte(TaxCollectorsCount);
			writer.WriteInt(TaxCollectorAttack);
			writer.WriteVarLong(Kamas);
			writer.WriteVarLong(Experience);
			writer.WriteVarInt((Int32)Pods);
			writer.WriteVarLong(ItemsValue);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MaxPods = (UInt16)reader.ReadVarShort();
			Prospecting = (UInt16)reader.ReadVarShort();
			Wisdom = (UInt16)reader.ReadVarShort();
			TaxCollectorsCount = reader.ReadByte();
			TaxCollectorAttack = reader.ReadInt();
			Kamas = reader.ReadVarLong();
			Experience = reader.ReadVarLong();
			Pods = (UInt32)reader.ReadVarInt();
			ItemsValue = reader.ReadVarLong();
		}
	}
}
