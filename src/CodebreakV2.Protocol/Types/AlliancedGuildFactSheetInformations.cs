using System;
namespace CodebreakV2.Protocol.Types
{
	public class AlliancedGuildFactSheetInformations : GuildInformations
	{
		public BasicNamedAllianceInformations AllianceInfos { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			AllianceInfos.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			AllianceInfos = new BasicNamedAllianceInformations();
			AllianceInfos.Deserialize(reader);
		}
	}
}
