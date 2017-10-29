using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TreasureHuntRequestMessage
	{
		public Byte QuestLevel { get; set; }
		public Byte QuestType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(QuestLevel);
			writer.WriteByte(QuestType);
		}
		public void Deserialize(IDataReader reader)
		{
			QuestLevel = reader.ReadByte();
			QuestType = reader.ReadByte();
		}
	}
}
