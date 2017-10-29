using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlaySpellAnimMessage
	{
		public Int64 CasterId { get; set; }
		public UInt16 TargetCellId { get; set; }
		public UInt16 SpellId { get; set; }
		public Int16 SpellLevel { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(CasterId);
			writer.WriteVarShort((Int16)TargetCellId);
			writer.WriteVarShort((Int16)SpellId);
			writer.WriteShort(SpellLevel);
		}
		public void Deserialize(IDataReader reader)
		{
			CasterId = reader.ReadVarLong();
			TargetCellId = (UInt16)reader.ReadVarShort();
			SpellId = (UInt16)reader.ReadVarShort();
			SpellLevel = reader.ReadShort();
		}
	}
}
