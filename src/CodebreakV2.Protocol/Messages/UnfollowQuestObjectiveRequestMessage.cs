using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class UnfollowQuestObjectiveRequestMessage
	{
		public UInt16 QuestId { get; set; }
		public Int16 ObjectiveId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)QuestId);
			writer.WriteShort(ObjectiveId);
		}
		public void Deserialize(IDataReader reader)
		{
			QuestId = (UInt16)reader.ReadVarShort();
			ObjectiveId = reader.ReadShort();
		}
	}
}
