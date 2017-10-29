using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicDateMessage
	{
		public Byte Day { get; set; }
		public Byte Month { get; set; }
		public UInt16 Year { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Day);
			writer.WriteByte(Month);
			writer.WriteShort((Int16)Year);
		}
		public void Deserialize(IDataReader reader)
		{
			Day = reader.ReadByte();
			Month = reader.ReadByte();
			Year = (UInt16)reader.ReadShort();
		}
	}
}
