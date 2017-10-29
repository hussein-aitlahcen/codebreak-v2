using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTemporarySpellBoostEffect : FightTemporaryBoostEffect
	{
		public UInt16 BoostedSpellId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)BoostedSpellId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			BoostedSpellId = (UInt16)reader.ReadVarShort();
		}
	}
}
