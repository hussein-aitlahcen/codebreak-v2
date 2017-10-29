using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
	{
		public Int16 MarkId { get; set; }
		public Double TriggeringCharacterId { get; set; }
		public UInt16 TriggeredSpellId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(MarkId);
			writer.WriteDouble(TriggeringCharacterId);
			writer.WriteVarShort((Int16)TriggeredSpellId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MarkId = reader.ReadShort();
			TriggeringCharacterId = reader.ReadDouble();
			TriggeredSpellId = (UInt16)reader.ReadVarShort();
		}
	}
}
