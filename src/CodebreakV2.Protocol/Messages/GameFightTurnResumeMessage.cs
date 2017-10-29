using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightTurnResumeMessage : GameFightTurnStartMessage
	{
		public UInt32 RemainingTime { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)RemainingTime);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			RemainingTime = (UInt32)reader.ReadVarInt();
		}
	}
}
