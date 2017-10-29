using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightResultMutantListEntry : FightResultFighterListEntry
	{
		public UInt16 Level { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)Level);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Level = (UInt16)reader.ReadVarShort();
		}
	}
}
