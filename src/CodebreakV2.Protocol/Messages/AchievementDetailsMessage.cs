using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AchievementDetailsMessage
	{
		public Achievement Achievement { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Achievement.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Achievement = new Achievement();
			Achievement.Deserialize(reader);
		}
	}
}
