using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeObjectMessage
	{
		public Boolean Remote { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Remote);
		}
		public void Deserialize(IDataReader reader)
		{
			Remote = reader.ReadBoolean();
		}
	}
}
