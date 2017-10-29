using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectEffectLadder : ObjectEffectCreature
	{
		public UInt32 MonsterCount { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)MonsterCount);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MonsterCount = (UInt32)reader.ReadVarInt();
		}
	}
}
