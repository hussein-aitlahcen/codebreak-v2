using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class QuestStepValidatedMessage
	{
		public UInt16 QuestId { get; set; }
		public UInt16 StepId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)QuestId);
			writer.WriteVarShort((Int16)StepId);
		}
		public void Deserialize(IDataReader reader)
		{
			QuestId = (UInt16)reader.ReadVarShort();
			StepId = (UInt16)reader.ReadVarShort();
		}
	}
}
