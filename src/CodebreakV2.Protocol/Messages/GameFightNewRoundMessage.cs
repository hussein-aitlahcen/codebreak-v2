using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightNewRoundMessage
	{
		public UInt32 RoundNumber { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)RoundNumber);
		}
		public void Deserialize(IDataReader reader)
		{
			RoundNumber = (UInt32)reader.ReadVarInt();
		}
	}
}
