using System;
namespace CodebreakV2.Protocol.Types
{
	public class PrismGeolocalizedInformation : PrismSubareaEmptyInfo
	{
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public Double MapId { get; set; }
		public PrismInformation Prism { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteDouble(MapId);
			Prism.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			MapId = reader.ReadDouble();
			Prism = new PrismInformation();
			Prism.Deserialize(reader);
		}
	}
}
