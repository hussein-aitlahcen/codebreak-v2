using System;
namespace CodebreakV2.Protocol.Types
{
	public class MapCoordinates
	{
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
		}
		public void Deserialize(IDataReader reader)
		{
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
		}
	}
}
