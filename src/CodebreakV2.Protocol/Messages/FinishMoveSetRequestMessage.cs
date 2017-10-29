using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class FinishMoveSetRequestMessage
	{
		public UInt32 FinishMoveId { get; set; }
		public Boolean FinishMoveState { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)FinishMoveId);
			writer.WriteBoolean(FinishMoveState);
		}
		public void Deserialize(IDataReader reader)
		{
			FinishMoveId = (UInt32)reader.ReadInt();
			FinishMoveState = reader.ReadBoolean();
		}
	}
}
