using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameMapMovementMessage
	{
		public UInt16[] KeyMovements { get; set; }
		public Int16 ForcedDirection { get; set; }
		public Double ActorId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < KeyMovements.Length; i++)
			{
				writer.WriteShort((Int16)KeyMovements[i]);
			}
			writer.WriteShort(ForcedDirection);
			writer.WriteDouble(ActorId);
		}
		public void Deserialize(IDataReader reader)
		{
			KeyMovements = new UInt16[reader.ReadShort()];
			for (var i = 0; i < KeyMovements.Length; i++)
			{
				KeyMovements[i] = (UInt16)reader.ReadShort();
			}
			ForcedDirection = reader.ReadShort();
			ActorId = reader.ReadDouble();
		}
	}
}
