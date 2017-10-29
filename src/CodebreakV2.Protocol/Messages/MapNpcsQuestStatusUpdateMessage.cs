using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MapNpcsQuestStatusUpdateMessage
	{
		public Double MapId { get; set; }
		public Int32[] NpcsIdsWithQuest { get; set; }
		public GameRolePlayNpcQuestFlag[] QuestFlags { get; set; }
		public Int32[] NpcsIdsWithoutQuest { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(MapId);
			for (var i = 0; i < NpcsIdsWithQuest.Length; i++)
			{
				writer.WriteInt(NpcsIdsWithQuest[i]);
			}
			for (var i = 0; i < QuestFlags.Length; i++)
			{
				QuestFlags[i].Serialize(writer);
			}
			for (var i = 0; i < NpcsIdsWithoutQuest.Length; i++)
			{
				writer.WriteInt(NpcsIdsWithoutQuest[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			MapId = reader.ReadDouble();
			NpcsIdsWithQuest = new Int32[reader.ReadShort()];
			for (var i = 0; i < NpcsIdsWithQuest.Length; i++)
			{
				NpcsIdsWithQuest[i] = reader.ReadInt();
			}
			QuestFlags = new GameRolePlayNpcQuestFlag[reader.ReadShort()];
			for (var i = 0; i < QuestFlags.Length; i++)
			{
				(QuestFlags[i] = new GameRolePlayNpcQuestFlag()).Deserialize(reader);
			}
			NpcsIdsWithoutQuest = new Int32[reader.ReadShort()];
			for (var i = 0; i < NpcsIdsWithoutQuest.Length; i++)
			{
				NpcsIdsWithoutQuest[i] = reader.ReadInt();
			}
		}
	}
}
