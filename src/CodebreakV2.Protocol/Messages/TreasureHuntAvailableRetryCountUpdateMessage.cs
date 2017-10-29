using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class TreasureHuntAvailableRetryCountUpdateMessage
	{
		public Byte QuestType { get; set; }
		public Int32 AvailableRetryCount { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(QuestType);
			writer.WriteInt(AvailableRetryCount);
		}
		public void Deserialize(IDataReader reader)
		{
			QuestType = reader.ReadByte();
			AvailableRetryCount = reader.ReadInt();
		}
	}
}
