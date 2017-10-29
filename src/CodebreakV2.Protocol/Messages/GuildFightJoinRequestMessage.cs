using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildFightJoinRequestMessage
	{
		public Double TaxCollectorId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(TaxCollectorId);
		}
		public void Deserialize(IDataReader reader)
		{
			TaxCollectorId = reader.ReadDouble();
		}
	}
}
