using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class QuestStepInfoMessage
	{
		public QuestActiveInformations Infos { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Infos.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Infos = new QuestActiveInformations();
			Infos.Deserialize(reader);
		}
	}
}
