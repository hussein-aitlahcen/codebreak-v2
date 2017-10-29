using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AchievementDetailsRequestMessage
	{
		public UInt16 AchievementId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)AchievementId);
		}
		public void Deserialize(IDataReader reader)
		{
			AchievementId = (UInt16)reader.ReadVarShort();
		}
	}
}
