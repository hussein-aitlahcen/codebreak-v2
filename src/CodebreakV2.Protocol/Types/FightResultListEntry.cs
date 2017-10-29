using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightResultListEntry
	{
		public UInt16 Outcome { get; set; }
		public Byte Wave { get; set; }
		public FightLoot Rewards { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Outcome);
			writer.WriteByte(Wave);
			Rewards.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Outcome = (UInt16)reader.ReadVarShort();
			Wave = reader.ReadByte();
			Rewards = new FightLoot();
			Rewards.Deserialize(reader);
		}
	}
}
