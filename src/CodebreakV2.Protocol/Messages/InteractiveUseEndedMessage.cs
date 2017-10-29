using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InteractiveUseEndedMessage
	{
		public UInt32 ElemId { get; set; }
		public UInt16 SkillId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ElemId);
			writer.WriteVarShort((Int16)SkillId);
		}
		public void Deserialize(IDataReader reader)
		{
			ElemId = (UInt32)reader.ReadVarInt();
			SkillId = (UInt16)reader.ReadVarShort();
		}
	}
}
