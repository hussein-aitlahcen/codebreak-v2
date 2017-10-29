using System;
namespace CodebreakV2.Protocol.Types
{
	public class SpellItem : Item
	{
		public Int32 SpellId { get; set; }
		public Int16 SpellLevel { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(SpellId);
			writer.WriteShort(SpellLevel);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SpellId = reader.ReadInt();
			SpellLevel = reader.ReadShort();
		}
	}
}
