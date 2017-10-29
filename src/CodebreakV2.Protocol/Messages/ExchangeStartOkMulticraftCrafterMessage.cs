using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartOkMulticraftCrafterMessage
	{
		public UInt32 SkillId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)SkillId);
		}
		public void Deserialize(IDataReader reader)
		{
			SkillId = (UInt32)reader.ReadVarInt();
		}
	}
}
