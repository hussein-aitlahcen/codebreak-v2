using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class QuestObjectiveValidatedMessage
	{
		public UInt16 QuestId { get; set; }
		public UInt16 ObjectiveId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)QuestId);
			writer.WriteVarShort((Int16)ObjectiveId);
		}
		public void Deserialize(IDataReader reader)
		{
			QuestId = (UInt16)reader.ReadVarShort();
			ObjectiveId = (UInt16)reader.ReadVarShort();
		}
	}
}
