using System;
namespace CodebreakV2.Protocol.Types
{
	public class ObjectEffectInteger : ObjectEffect
	{
		public UInt32 Value { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)Value);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Value = (UInt32)reader.ReadVarInt();
		}
	}
}
