using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildInAllianceFactsMessage : GuildFactsMessage
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
