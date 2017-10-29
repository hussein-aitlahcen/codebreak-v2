using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightTurnStartMessage
	{
		public Double Id { get; set; }
		public UInt32 WaitTime { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(Id);
			writer.WriteVarInt((Int32)WaitTime);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadDouble();
			WaitTime = (UInt32)reader.ReadVarInt();
		}
	}
}
