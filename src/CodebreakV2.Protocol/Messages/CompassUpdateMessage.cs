using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CompassUpdateMessage
	{
		public Byte Type { get; set; }
		public MapCoordinates Coords { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Type);
			Coords.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Type = reader.ReadByte();
			Coords = new MapCoordinates();
			Coords.Deserialize(reader);
		}
	}
}
