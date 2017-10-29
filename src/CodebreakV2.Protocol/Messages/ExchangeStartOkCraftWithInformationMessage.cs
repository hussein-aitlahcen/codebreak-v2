using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartOkCraftWithInformationMessage : ExchangeStartOkCraftMessage
	{
		public UInt32 SkillId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)SkillId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			SkillId = (UInt32)reader.ReadVarInt();
		}
	}
}
