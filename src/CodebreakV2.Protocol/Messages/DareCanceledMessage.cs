using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DareCanceledMessage
	{
		public Double DareId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(DareId);
		}
		public void Deserialize(IDataReader reader)
		{
			DareId = reader.ReadDouble();
		}
	}
}
