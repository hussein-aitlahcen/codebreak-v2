using System;
namespace CodebreakV2.Protocol.Types
{
	public class AbstractFightDispellableEffect
	{
		public UInt32 Uid { get; set; }
		public Double TargetId { get; set; }
		public Int16 TurnDuration { get; set; }
		public Byte Dispelable { get; set; }
		public UInt16 SpellId { get; set; }
		public UInt32 EffectId { get; set; }
		public UInt32 ParentBoostUid { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)Uid);
			writer.WriteDouble(TargetId);
			writer.WriteShort(TurnDuration);
			writer.WriteByte(Dispelable);
			writer.WriteVarShort((Int16)SpellId);
			writer.WriteVarInt((Int32)EffectId);
			writer.WriteVarInt((Int32)ParentBoostUid);
		}
		public void Deserialize(IDataReader reader)
		{
			Uid = (UInt32)reader.ReadVarInt();
			TargetId = reader.ReadDouble();
			TurnDuration = reader.ReadShort();
			Dispelable = reader.ReadByte();
			SpellId = (UInt16)reader.ReadVarShort();
			EffectId = (UInt32)reader.ReadVarInt();
			ParentBoostUid = (UInt32)reader.ReadVarInt();
		}
	}
}
