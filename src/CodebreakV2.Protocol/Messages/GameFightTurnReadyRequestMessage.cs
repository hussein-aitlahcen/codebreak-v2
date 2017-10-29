using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightTurnReadyRequestMessage
	{
		public Double Id { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(Id);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadDouble();
		}
	}
}
