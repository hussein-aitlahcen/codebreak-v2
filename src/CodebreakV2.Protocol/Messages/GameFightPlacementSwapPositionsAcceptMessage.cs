using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightPlacementSwapPositionsAcceptMessage
	{
		public UInt32 RequestId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt((Int32)RequestId);
		}
		public void Deserialize(IDataReader reader)
		{
			RequestId = (UInt32)reader.ReadInt();
		}
	}
}
