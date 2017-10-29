using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TaxCollectorDialogQuestionBasicMessage
	{
		public BasicGuildInformations GuildInfo { get; set; }
		public void Serialize(IDataWriter writer)
		{
			GuildInfo.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			GuildInfo = new BasicGuildInformations();
			GuildInfo.Deserialize(reader);
		}
	}
}
