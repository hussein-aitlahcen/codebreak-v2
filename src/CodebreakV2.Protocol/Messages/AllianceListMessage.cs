using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceListMessage
	{
		public AllianceFactSheetInformations[] Alliances { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Alliances.Length; i++)
			{
				Alliances[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Alliances = new AllianceFactSheetInformations[reader.ReadShort()];
			for (var i = 0; i < Alliances.Length; i++)
			{
				(Alliances[i] = new AllianceFactSheetInformations()).Deserialize(reader);
			}
		}
	}
}
