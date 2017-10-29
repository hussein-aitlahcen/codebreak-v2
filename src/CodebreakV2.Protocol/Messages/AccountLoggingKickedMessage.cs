using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AccountLoggingKickedMessage
	{
		public UInt16 Days { get; set; }
		public Byte Hours { get; set; }
		public Byte Minutes { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Days);
			writer.WriteByte(Hours);
			writer.WriteByte(Minutes);
		}
		public void Deserialize(IDataReader reader)
		{
			Days = (UInt16)reader.ReadVarShort();
			Hours = reader.ReadByte();
			Minutes = reader.ReadByte();
		}
	}
}
