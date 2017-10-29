using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterSpellModification
	{
		public Byte ModificationType { get; set; }
		public UInt16 SpellId { get; set; }
		public CharacterBaseCharacteristic Value { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(ModificationType);
			writer.WriteVarShort((Int16)SpellId);
			Value.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			ModificationType = reader.ReadByte();
			SpellId = (UInt16)reader.ReadVarShort();
			Value = new CharacterBaseCharacteristic();
			Value.Deserialize(reader);
		}
	}
}
