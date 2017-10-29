using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameMapMovementRequestMessage
	{
		public UInt16[] KeyMovements { get; set; }
		public Double MapId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < KeyMovements.Length; i++)
			{
				writer.WriteShort((Int16)KeyMovements[i]);
			}
			writer.WriteDouble(MapId);
		}
		public void Deserialize(IDataReader reader)
		{
			KeyMovements = new UInt16[reader.ReadShort()];
			for (var i = 0; i < KeyMovements.Length; i++)
			{
				KeyMovements[i] = (UInt16)reader.ReadShort();
			}
			MapId = reader.ReadDouble();
		}
	}
}
