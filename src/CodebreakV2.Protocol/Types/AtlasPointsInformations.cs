using System;
namespace CodebreakV2.Protocol.Types
{
	public class AtlasPointsInformations
	{
		public Byte Type { get; set; }
		public MapCoordinatesExtended[] Coords { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Type);
			for (var i = 0; i < Coords.Length; i++)
			{
				Coords[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Type = reader.ReadByte();
			Coords = new MapCoordinatesExtended[reader.ReadShort()];
			for (var i = 0; i < Coords.Length; i++)
			{
				(Coords[i] = new MapCoordinatesExtended()).Deserialize(reader);
			}
		}
	}
}
