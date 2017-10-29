using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TaxCollectorAttackedResultMessage
	{
		public Boolean DeadOrAlive { get; set; }
		public TaxCollectorBasicInformations BasicInfos { get; set; }
		public BasicGuildInformations Guild { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(DeadOrAlive);
			BasicInfos.Serialize(writer);
			Guild.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			DeadOrAlive = reader.ReadBoolean();
			BasicInfos = new TaxCollectorBasicInformations();
			BasicInfos.Deserialize(reader);
			Guild = new BasicGuildInformations();
			Guild.Deserialize(reader);
		}
	}
}
