using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GuildFightLeaveRequestMessage
	{
		public Double TaxCollectorId { get; set; }
		public Int64 CharacterId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(TaxCollectorId);
			writer.WriteVarLong(CharacterId);
		}
		public void Deserialize(IDataReader reader)
		{
			TaxCollectorId = reader.ReadDouble();
			CharacterId = reader.ReadVarLong();
		}
	}
}
