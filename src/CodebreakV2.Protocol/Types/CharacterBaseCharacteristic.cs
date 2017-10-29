using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterBaseCharacteristic
	{
		public Int16 Base { get; set; }
		public Int16 Additionnal { get; set; }
		public Int16 ObjectsAndMountBonus { get; set; }
		public Int16 AlignGiftBonus { get; set; }
		public Int16 ContextModif { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort(Base);
			writer.WriteVarShort(Additionnal);
			writer.WriteVarShort(ObjectsAndMountBonus);
			writer.WriteVarShort(AlignGiftBonus);
			writer.WriteVarShort(ContextModif);
		}
		public void Deserialize(IDataReader reader)
		{
			Base = reader.ReadVarShort();
			Additionnal = reader.ReadVarShort();
			ObjectsAndMountBonus = reader.ReadVarShort();
			AlignGiftBonus = reader.ReadVarShort();
			ContextModif = reader.ReadVarShort();
		}
	}
}
