using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class InteractiveUseRequestMessage
	{
		public UInt32 ElemId { get; set; }
		public UInt32 SkillInstanceUid { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ElemId);
			writer.WriteVarInt((Int32)SkillInstanceUid);
		}
		public void Deserialize(IDataReader reader)
		{
			ElemId = (UInt32)reader.ReadVarInt();
			SkillInstanceUid = (UInt32)reader.ReadVarInt();
		}
	}
}
