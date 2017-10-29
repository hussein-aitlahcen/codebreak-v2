using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MapComplementaryInformationsDataInHouseMessage : MapComplementaryInformationsDataMessage
	{
		public HouseInformationsInside CurrentHouse { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			CurrentHouse.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CurrentHouse = new HouseInformationsInside();
			CurrentHouse.Deserialize(reader);
		}
	}
}
