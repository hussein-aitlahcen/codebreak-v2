using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameMapNoMovementMessage
	{
		public Int16 CellX { get; set; }
		public Int16 CellY { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort(CellX);
			writer.WriteShort(CellY);
		}
		public void Deserialize(IDataReader reader)
		{
			CellX = reader.ReadShort();
			CellY = reader.ReadShort();
		}
	}
}
