using System;
namespace CodebreakV2.Protocol.Types
{
	public class MapCoordinatesAndId : MapCoordinates
	{
		public Double MapId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(MapId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			MapId = reader.ReadDouble();
		}
	}
}
