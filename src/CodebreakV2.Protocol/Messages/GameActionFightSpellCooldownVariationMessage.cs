using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightSpellCooldownVariationMessage : AbstractGameActionMessage
	{
		public Double TargetId { get; set; }
		public UInt16 SpellId { get; set; }
		public Int16 Value { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(TargetId);
			writer.WriteVarShort((Int16)SpellId);
			writer.WriteVarShort(Value);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			TargetId = reader.ReadDouble();
			SpellId = (UInt16)reader.ReadVarShort();
			Value = reader.ReadVarShort();
		}
	}
}
