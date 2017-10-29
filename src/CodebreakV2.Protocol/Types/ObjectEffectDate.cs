using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectEffectDate : ObjectEffect
	{
		public UInt16 Year { get; set; }
		public Byte Month { get; set; }
		public Byte Day { get; set; }
		public Byte Hour { get; set; }
		public Byte Minute { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)Year);
			writer.WriteByte(Month);
			writer.WriteByte(Day);
			writer.WriteByte(Hour);
			writer.WriteByte(Minute);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Year = (UInt16)reader.ReadVarShort();
			Month = reader.ReadByte();
			Day = reader.ReadByte();
			Hour = reader.ReadByte();
			Minute = reader.ReadByte();
		}
	}
}
