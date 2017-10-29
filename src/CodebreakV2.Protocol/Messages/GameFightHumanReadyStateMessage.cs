using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightHumanReadyStateMessage
	{
		public Int64 CharacterId { get; set; }
		public Boolean IsReady { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(CharacterId);
			writer.WriteBoolean(IsReady);
		}
		public void Deserialize(IDataReader reader)
		{
			CharacterId = reader.ReadVarLong();
			IsReady = reader.ReadBoolean();
		}
	}
}
