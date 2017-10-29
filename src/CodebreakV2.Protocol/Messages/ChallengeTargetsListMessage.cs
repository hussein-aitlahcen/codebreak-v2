using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ChallengeTargetsListMessage
	{
		public Double[] TargetIds { get; set; }
		public Int16[] TargetCells { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < TargetIds.Length; i++)
			{
				writer.WriteDouble(TargetIds[i]);
			}
			for (var i = 0; i < TargetCells.Length; i++)
			{
				writer.WriteShort(TargetCells[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			TargetIds = new Double[reader.ReadShort()];
			for (var i = 0; i < TargetIds.Length; i++)
			{
				TargetIds[i] = reader.ReadDouble();
			}
			TargetCells = new Int16[reader.ReadShort()];
			for (var i = 0; i < TargetCells.Length; i++)
			{
				TargetCells[i] = reader.ReadShort();
			}
		}
	}
}
