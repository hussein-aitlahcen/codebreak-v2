using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TreasureHuntFlagRequestAnswerMessage
	{
		public Byte QuestType { get; set; }
		public Byte Result { get; set; }
		public Byte Index { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(QuestType);
			writer.WriteByte(Result);
			writer.WriteByte(Index);
		}
		public void Deserialize(IDataReader reader)
		{
			QuestType = reader.ReadByte();
			Result = reader.ReadByte();
			Index = reader.ReadByte();
		}
	}
}
