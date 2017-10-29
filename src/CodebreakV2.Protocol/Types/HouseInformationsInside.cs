using System;
namespace CodebreakV2.Protocol.Types
{
	public class HouseInformationsInside : HouseInformations
	{
		public HouseInstanceInformations HouseInfos { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			HouseInfos.Serialize(writer);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			HouseInfos = new HouseInstanceInformations();
			HouseInfos.Deserialize(reader);
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
		}
	}
}
