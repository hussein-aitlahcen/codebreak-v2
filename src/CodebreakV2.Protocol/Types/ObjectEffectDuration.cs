using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectEffectDuration : ObjectEffect
	{
		public UInt16 Days { get; set; }
		public Byte Hours { get; set; }
		public Byte Minutes { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)Days);
			writer.WriteByte(Hours);
			writer.WriteByte(Minutes);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Days = (UInt16)reader.ReadVarShort();
			Hours = reader.ReadByte();
			Minutes = reader.ReadByte();
		}
	}
}
