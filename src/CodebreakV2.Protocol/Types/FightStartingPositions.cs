using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightStartingPositions
	{
		public UInt16[] PositionsForChallengers { get; set; }
		public UInt16[] PositionsForDefenders { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < PositionsForChallengers.Length; i++)
			{
				writer.WriteVarShort((Int16)PositionsForChallengers[i]);
			}
			for (var i = 0; i < PositionsForDefenders.Length; i++)
			{
				writer.WriteVarShort((Int16)PositionsForDefenders[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PositionsForChallengers = new UInt16[reader.ReadShort()];
			for (var i = 0; i < PositionsForChallengers.Length; i++)
			{
				PositionsForChallengers[i] = (UInt16)reader.ReadVarShort();
			}
			PositionsForDefenders = new UInt16[reader.ReadShort()];
			for (var i = 0; i < PositionsForDefenders.Length; i++)
			{
				PositionsForDefenders[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
