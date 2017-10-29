using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AchievementDetailedListRequestMessage
	{
		public UInt16 CategoryId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)CategoryId);
		}
		public void Deserialize(IDataReader reader)
		{
			CategoryId = (UInt16)reader.ReadVarShort();
		}
	}
}
