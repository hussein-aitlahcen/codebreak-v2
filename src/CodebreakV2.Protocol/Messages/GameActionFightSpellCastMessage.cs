using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightSpellCastMessage : AbstractGameActionFightTargetedAbilityMessage
	{
		public UInt16 SpellId { get; set; }
		public Int16 SpellLevel { get; set; }
		public Int16[] PortalsIds { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)SpellId);
			writer.WriteShort(SpellLevel);
			for (var i = 0; i < PortalsIds.Length; i++)
			{
				writer.WriteShort(PortalsIds[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SpellId = (UInt16)reader.ReadVarShort();
			SpellLevel = reader.ReadShort();
			PortalsIds = new Int16[reader.ReadShort()];
			for (var i = 0; i < PortalsIds.Length; i++)
			{
				PortalsIds[i] = reader.ReadShort();
			}
		}
	}
}
