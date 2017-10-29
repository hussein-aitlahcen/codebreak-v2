using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildHousesInformationMessage
	{
		public HouseInformationsForGuild[] HousesInformations { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < HousesInformations.Length; i++)
			{
				HousesInformations[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			HousesInformations = new HouseInformationsForGuild[reader.ReadShort()];
			for (var i = 0; i < HousesInformations.Length; i++)
			{
				(HousesInformations[i] = new HouseInformationsForGuild()).Deserialize(reader);
			}
		}
	}
}
