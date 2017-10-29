using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class RefreshFollowedQuestsOrderRequestMessage
	{
		public UInt16[] Quests { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Quests.Length; i++)
			{
				writer.WriteVarShort((Int16)Quests[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Quests = new UInt16[reader.ReadShort()];
			for (var i = 0; i < Quests.Length; i++)
			{
				Quests[i] = (UInt16)reader.ReadVarShort();
			}
		}
	}
}
