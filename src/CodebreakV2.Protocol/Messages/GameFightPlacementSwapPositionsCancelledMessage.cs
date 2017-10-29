using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightPlacementSwapPositionsCancelledMessage
	{
		public UInt32 RequestId { get; set; }
		public Double CancellerId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)RequestId);
			writer.WriteDouble(CancellerId);
		}
		public void Deserialize(IDataReader reader)
		{
			RequestId = (UInt32)reader.ReadInt();
			CancellerId = reader.ReadDouble();
		}
	}
}
