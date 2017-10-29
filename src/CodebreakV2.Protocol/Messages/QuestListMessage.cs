using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class QuestListMessage
	{
		public UInt16[] FinishedQuestsIds { get; set; }
		public UInt16[] FinishedQuestsCounts { get; set; }
		public QuestActiveInformations[] ActiveQuests { get; set; }
		public UInt16[] ReinitDoneQuestsIds { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < FinishedQuestsIds.Length; i++)
			{
				writer.WriteVarShort((Int16)FinishedQuestsIds[i]);
			}
			for (var i = 0; i < FinishedQuestsCounts.Length; i++)
			{
				writer.WriteVarShort((Int16)FinishedQuestsCounts[i]);
			}
			for (var i = 0; i < ActiveQuests.Length; i++)
			{
				ActiveQuests[i].Serialize(writer);
			}
			for (var i = 0; i < ReinitDoneQuestsIds.Length; i++)
			{
				writer.WriteVarShort((Int16)ReinitDoneQuestsIds[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			FinishedQuestsIds = new UInt16[reader.ReadShort()];
			for (var i = 0; i < FinishedQuestsIds.Length; i++)
			{
				FinishedQuestsIds[i] = (UInt16)reader.ReadVarShort();
			}
			FinishedQuestsCounts = new UInt16[reader.ReadShort()];
			for (var i = 0; i < FinishedQuestsCounts.Length; i++)
			{
				FinishedQuestsCounts[i] = (UInt16)reader.ReadVarShort();
			}
			ActiveQuests = new QuestActiveInformations[reader.ReadShort()];
			for (var i = 0; i < ActiveQuests.Length; i++)
			{
				(ActiveQuests[i] = new QuestActiveInformations()).Deserialize(reader);
			}
			ReinitDoneQuestsIds = new UInt16[reader.ReadShort()];
			for (var i = 0; i < ReinitDoneQuestsIds.Length; i++)
			{
				ReinitDoneQuestsIds[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
