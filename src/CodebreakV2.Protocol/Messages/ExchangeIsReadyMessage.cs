using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeIsReadyMessage
	{
		public Double Id { get; set; }
		public Boolean Ready { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(Id);
			writer.WriteBoolean(Ready);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadDouble();
			Ready = reader.ReadBoolean();
		}
	}
}
