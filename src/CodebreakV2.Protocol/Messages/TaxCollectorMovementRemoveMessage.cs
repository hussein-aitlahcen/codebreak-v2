using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TaxCollectorMovementRemoveMessage
	{
		public Double CollectorId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(CollectorId);
		}
		public void Deserialize(IDataReader reader)
		{
			CollectorId = reader.ReadDouble();
		}
	}
}
