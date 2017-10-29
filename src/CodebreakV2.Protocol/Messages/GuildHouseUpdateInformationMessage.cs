using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildHouseUpdateInformationMessage
	{
		public HouseInformationsForGuild HousesInformations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			HousesInformations.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			HousesInformations = new HouseInformationsForGuild();
			HousesInformations.Deserialize(reader);
		}
	}
}
