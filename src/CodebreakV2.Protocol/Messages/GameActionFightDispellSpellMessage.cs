using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
	{
		public UInt16 SpellId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)SpellId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SpellId = (UInt16)reader.ReadVarShort();
		}
	}
}
