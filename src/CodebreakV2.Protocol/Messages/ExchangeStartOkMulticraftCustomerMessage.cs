using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartOkMulticraftCustomerMessage
	{
		public UInt32 SkillId { get; set; }
		public Byte CrafterJobLevel { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)SkillId);
			writer.WriteByte(CrafterJobLevel);
		}
		public void Deserialize(IDataReader reader)
		{
			SkillId = (UInt32)reader.ReadVarInt();
			CrafterJobLevel = reader.ReadByte();
		}
	}
}
