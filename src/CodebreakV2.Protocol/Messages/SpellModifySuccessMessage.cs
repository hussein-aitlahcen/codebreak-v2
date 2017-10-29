using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SpellModifySuccessMessage
	{
		public Int32 SpellId { get; set; }
		public Int16 SpellLevel { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(SpellId);
			writer.WriteShort(SpellLevel);
		}
		public void Deserialize(IDataReader reader)
		{
			SpellId = reader.ReadInt();
			SpellLevel = reader.ReadShort();
		}
	}
}
