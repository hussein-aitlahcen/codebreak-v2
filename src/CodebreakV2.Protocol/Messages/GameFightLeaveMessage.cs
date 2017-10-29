using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightLeaveMessage
	{
		public Double CharId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(CharId);
		}
		public void Deserialize(IDataReader reader)
		{
			CharId = reader.ReadDouble();
		}
	}
}
