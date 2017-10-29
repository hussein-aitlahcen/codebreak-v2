using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TreasureHuntRequestAnswerMessage
	{
		public Byte QuestType { get; set; }
		public Byte Result { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(QuestType);
			writer.WriteByte(Result);
		}
		public void Deserialize(IDataReader reader)
		{
			QuestType = reader.ReadByte();
			Result = reader.ReadByte();
		}
	}
}
