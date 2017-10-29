using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SpellModifyRequestMessage
	{
		public UInt16 SpellId { get; set; }
		public Int16 SpellLevel { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SpellId);
			writer.WriteShort(SpellLevel);
		}
		public void Deserialize(IDataReader reader)
		{
			SpellId = (UInt16)reader.ReadVarShort();
			SpellLevel = reader.ReadShort();
		}
	}
}
