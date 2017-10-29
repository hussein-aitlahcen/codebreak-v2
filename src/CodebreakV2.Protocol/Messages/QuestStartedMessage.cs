using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class QuestStartedMessage
	{
		public UInt16 QuestId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)QuestId);
		}
		public void Deserialize(IDataReader reader)
		{
			QuestId = (UInt16)reader.ReadVarShort();
		}
	}
}
