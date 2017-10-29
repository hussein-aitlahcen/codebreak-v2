using System;
namespace CodebreakV2.Protocol.Types
{
	public class PaddockGuildedInformations : PaddockBuyableInformations
	{
		public Boolean Deserted { get; set; }
		public GuildInformations GuildInfo { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(Deserted);
			GuildInfo.Serialize(writer);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Deserted = reader.ReadBoolean();
			GuildInfo = new GuildInformations();
			GuildInfo.Deserialize(reader);
		}
	}
}
