using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectEffectMinMax : ObjectEffect
	{
		public UInt32 Min { get; set; }
		public UInt32 Max { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)Min);
			writer.WriteVarInt((Int32)Max);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Min = (UInt32)reader.ReadVarInt();
			Max = (UInt32)reader.ReadVarInt();
		}
	}
}
