using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AllianceInsiderInfoMessage
	{
		public AllianceFactSheetInformations AllianceInfos { get; set; }
		public GuildInsiderFactSheetInformations[] Guilds { get; set; }
		public PrismSubareaEmptyInfo[] Prisms { get; set; }
		public void Serialize(IDataWriter writer)
		{
			AllianceInfos.Serialize(writer);
			for (var i = 0; i < Guilds.Length; i++)
			{
				Guilds[i].Serialize(writer);
			}
			for (var i = 0; i < Prisms.Length; i++)
			{
				Prisms[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			AllianceInfos = new AllianceFactSheetInformations();
			AllianceInfos.Deserialize(reader);
			Guilds = new GuildInsiderFactSheetInformations[reader.ReadShort()];
			for (var i = 0; i < Guilds.Length; i++)
			{
				(Guilds[i] = new GuildInsiderFactSheetInformations()).Deserialize(reader);
			}
			Prisms = new PrismSubareaEmptyInfo[reader.ReadShort()];
			for (var i = 0; i < Prisms.Length; i++)
			{
				(Prisms[i] = new PrismSubareaEmptyInfo()).Deserialize(reader);
			}
		}
	}
}
