using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectEffectCreature : ObjectEffect
	{
		public UInt16 MonsterFamilyId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)MonsterFamilyId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MonsterFamilyId = (UInt16)reader.ReadVarShort();
		}
	}
}
