using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeOkMultiCraftMessage
	{
		public Int64 InitiatorId { get; set; }
		public Int64 OtherId { get; set; }
		public SByte Role { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(InitiatorId);
			writer.WriteVarLong(OtherId);
			writer.WriteByte((Byte)Role);
		}
		public void Deserialize(IDataReader reader)
		{
			InitiatorId = reader.ReadVarLong();
			OtherId = reader.ReadVarLong();
			Role = (SByte)reader.ReadByte();
		}
	}
}
