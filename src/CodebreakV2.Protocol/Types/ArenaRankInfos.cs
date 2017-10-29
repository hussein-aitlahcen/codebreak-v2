using System;
namespace CodebreakV2.Protocol.Types
{
	public class ArenaRankInfos
	{
		public UInt16 Rank { get; set; }
		public UInt16 BestRank { get; set; }
		public UInt16 VictoryCount { get; set; }
		public UInt16 Fightcount { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Rank);
			writer.WriteVarShort((Int16)BestRank);
			writer.WriteVarShort((Int16)VictoryCount);
			writer.WriteVarShort((Int16)Fightcount);
		}
		public void Deserialize(IDataReader reader)
		{
			Rank = (UInt16)reader.ReadVarShort();
			BestRank = (UInt16)reader.ReadVarShort();
			VictoryCount = (UInt16)reader.ReadVarShort();
			Fightcount = (UInt16)reader.ReadVarShort();
		}
	}
}
