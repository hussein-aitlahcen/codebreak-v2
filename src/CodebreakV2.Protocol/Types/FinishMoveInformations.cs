using System;
namespace CodebreakV2.Protocol.Types
{
	public class FinishMoveInformations
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
