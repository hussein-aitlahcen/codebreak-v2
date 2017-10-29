using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterReportMessage
	{
		public Int64 ReportedId { get; set; }
		public Byte Reason { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(ReportedId);
			writer.WriteByte(Reason);
		}
		public void Deserialize(IDataReader reader)
		{
			ReportedId = reader.ReadVarLong();
			Reason = reader.ReadByte();
		}
	}
}
