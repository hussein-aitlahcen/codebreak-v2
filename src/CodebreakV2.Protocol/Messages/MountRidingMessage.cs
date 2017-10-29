using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MountRidingMessage
	{
		public Boolean IsRiding { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(IsRiding);
		}
		public void Deserialize(IDataReader reader)
		{
			IsRiding = reader.ReadBoolean();
		}
	}
}
