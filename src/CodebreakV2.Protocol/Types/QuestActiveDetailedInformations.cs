using System;
namespace CodebreakV2.Protocol.Types
{
	public class QuestActiveDetailedInformations : QuestActiveInformations
	{
		public UInt16 StepId { get; set; }
		public QuestObjectiveInformations[] Objectives { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)StepId);
			for (var i = 0; i < Objectives.Length; i++)
			{
				Objectives[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			StepId = (UInt16)reader.ReadVarShort();
			Objectives = new QuestObjectiveInformations[reader.ReadShort()];
			for (var i = 0; i < Objectives.Length; i++)
			{
				(Objectives[i] = new QuestObjectiveInformations()).Deserialize(reader);
			}
		}
	}
}
