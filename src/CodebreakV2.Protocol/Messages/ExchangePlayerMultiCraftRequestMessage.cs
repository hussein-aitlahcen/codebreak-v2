using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangePlayerMultiCraftRequestMessage : ExchangeRequestMessage
	{
		public Int64 Target { get; set; }
		public UInt32 SkillId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(Target);
			writer.WriteVarInt((Int32)SkillId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Target = reader.ReadVarLong();
			SkillId = (UInt32)reader.ReadVarInt();
		}
	}
}
