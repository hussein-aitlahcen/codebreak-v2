using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightTurnFinishMessage
	{
		public Boolean IsAfk { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(IsAfk);
		}
		public void Deserialize(IDataReader reader)
		{
			IsAfk = reader.ReadBoolean();
		}
	}
}
