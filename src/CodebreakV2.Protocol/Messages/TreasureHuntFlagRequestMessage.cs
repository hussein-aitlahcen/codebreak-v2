using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TreasureHuntFlagRequestMessage
	{
		public Byte QuestType { get; set; }
		public Byte Index { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(QuestType);
			writer.WriteByte(Index);
		}
		public void Deserialize(IDataReader reader)
		{
			QuestType = reader.ReadByte();
			Index = reader.ReadByte();
		}
	}
}
