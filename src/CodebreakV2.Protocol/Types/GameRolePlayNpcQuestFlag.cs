using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayNpcQuestFlag
	{
		public UInt16[] QuestsToValidId { get; set; }
		public UInt16[] QuestsToStartId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < QuestsToValidId.Length; i++)
			{
				writer.WriteVarShort((Int16)QuestsToValidId[i]);
			}
			for (var i = 0; i < QuestsToStartId.Length; i++)
			{
				writer.WriteVarShort((Int16)QuestsToStartId[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			QuestsToValidId = new UInt16[reader.ReadShort()];
			for (var i = 0; i < QuestsToValidId.Length; i++)
			{
				QuestsToValidId[i] = (UInt16)reader.ReadVarShort();
			}
			QuestsToStartId = new UInt16[reader.ReadShort()];
			for (var i = 0; i < QuestsToStartId.Length; i++)
			{
				QuestsToStartId[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
