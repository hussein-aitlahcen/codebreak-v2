using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildPaddockBoughtMessage
	{
		public PaddockContentInformations PaddockInfo { get; set; }
		public void Serialize(IDataWriter writer)
		{
			PaddockInfo.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			PaddockInfo = new PaddockContentInformations();
			PaddockInfo.Deserialize(reader);
		}
	}
}
