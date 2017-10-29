using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MapComplementaryInformationsWithCoordsMessage : MapComplementaryInformationsDataMessage
	{
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
		}
	}
}
