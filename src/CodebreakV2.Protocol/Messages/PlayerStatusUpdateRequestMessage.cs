using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PlayerStatusUpdateRequestMessage
	{
		public PlayerStatus Status { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Status.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Status = new PlayerStatus();
			Status.Deserialize(reader);
		}
	}
}
