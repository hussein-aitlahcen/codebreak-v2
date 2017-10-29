using System;
namespace CodebreakV2.Protocol.Types
{
	public class HouseOnMapInformations : HouseInformations
	{
		public UInt32[] DoorsOnMap { get; set; }
		public HouseInstanceInformations[] HouseInstances { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < DoorsOnMap.Length; i++)
			{
				writer.WriteInt((Int32)DoorsOnMap[i]);
			}
			for (var i = 0; i < HouseInstances.Length; i++)
			{
				HouseInstances[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			DoorsOnMap = new UInt32[reader.ReadShort()];
			for (var i = 0; i < DoorsOnMap.Length; i++)
			{
				DoorsOnMap[i] = (UInt32)reader.ReadInt();
			}
			HouseInstances = new HouseInstanceInformations[reader.ReadShort()];
			for (var i = 0; i < HouseInstances.Length; i++)
			{
				(HouseInstances[i] = new HouseInstanceInformations()).Deserialize(reader);
			}
		}
	}
}
