using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeReadyMessage
	{
		public Boolean Ready { get; set; }
		public UInt16 Step { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(Ready);
			writer.WriteVarShort((Int16)Step);
		}
		public void Deserialize(IDataReader reader)
		{
			Ready = reader.ReadBoolean();
			Step = (UInt16)reader.ReadVarShort();
		}
	}
}
