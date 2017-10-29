using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightTurnReadyMessage
	{
		public Boolean IsReady { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(IsReady);
		}
		public void Deserialize(IDataReader reader)
		{
			IsReady = reader.ReadBoolean();
		}
	}
}
