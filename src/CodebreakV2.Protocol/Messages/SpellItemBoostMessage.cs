using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SpellItemBoostMessage
	{
		public UInt32 StatId { get; set; }
		public UInt16 SpellId { get; set; }
		public Int16 Value { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)StatId);
			writer.WriteVarShort((Int16)SpellId);
			writer.WriteVarShort(Value);
		}
		public void Deserialize(IDataReader reader)
		{
			StatId = (UInt32)reader.ReadVarInt();
			SpellId = (UInt16)reader.ReadVarShort();
			Value = reader.ReadVarShort();
		}
	}
}
