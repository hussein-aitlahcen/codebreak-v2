using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeRequestMessage
	{
		public SByte ExchangeType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte((Byte)ExchangeType);
		}
		public void Deserialize(IDataReader reader)
		{
			ExchangeType = (SByte)reader.ReadByte();
		}
	}
}
