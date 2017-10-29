using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class FinishMoveListMessage
	{
		public FinishMoveInformations[] FinishMoves { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < FinishMoves.Length; i++)
			{
				FinishMoves[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			FinishMoves = new FinishMoveInformations[reader.ReadShort()];
			for (var i = 0; i < FinishMoves.Length; i++)
			{
				(FinishMoves[i] = new FinishMoveInformations()).Deserialize(reader);
			}
		}
	}
}
