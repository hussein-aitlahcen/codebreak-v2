using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TreasureHuntDigRequestMessage
	{
		public Byte QuestType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(QuestType);
		}
		public void Deserialize(IDataReader reader)
		{
			QuestType = reader.ReadByte();
		}
	}
}
