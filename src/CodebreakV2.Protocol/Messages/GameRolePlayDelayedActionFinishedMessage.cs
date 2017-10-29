using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayDelayedActionFinishedMessage
	{
		public Double DelayedCharacterId { get; set; }
		public Byte DelayTypeId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(DelayedCharacterId);
			writer.WriteByte(DelayTypeId);
		}
		public void Deserialize(IDataReader reader)
		{
			DelayedCharacterId = reader.ReadDouble();
			DelayTypeId = reader.ReadByte();
		}
	}
}
