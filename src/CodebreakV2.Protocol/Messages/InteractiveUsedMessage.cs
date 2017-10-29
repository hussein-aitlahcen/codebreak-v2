using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InteractiveUsedMessage
	{
		public Int64 EntityId { get; set; }
		public UInt32 ElemId { get; set; }
		public UInt16 SkillId { get; set; }
		public UInt16 Duration { get; set; }
		public Boolean CanMove { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(EntityId);
			writer.WriteVarInt((Int32)ElemId);
			writer.WriteVarShort((Int16)SkillId);
			writer.WriteVarShort((Int16)Duration);
			writer.WriteBoolean(CanMove);
		}
		public void Deserialize(IDataReader reader)
		{
			EntityId = reader.ReadVarLong();
			ElemId = (UInt32)reader.ReadVarInt();
			SkillId = (UInt16)reader.ReadVarShort();
			Duration = (UInt16)reader.ReadVarShort();
			CanMove = reader.ReadBoolean();
		}
	}
}
