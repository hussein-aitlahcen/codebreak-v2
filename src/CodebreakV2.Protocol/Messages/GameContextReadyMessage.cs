using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameContextReadyMessage
	{
		public Double MapId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(MapId);
		}
		public void Deserialize(IDataReader reader)
		{
			MapId = reader.ReadDouble();
		}
	}
}
