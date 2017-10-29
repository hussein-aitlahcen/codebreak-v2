using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameRolePlayPlayerLifeStatusMessage
	{
		public Byte State { get; set; }
		public Double PhenixMapId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(State);
			writer.WriteDouble(PhenixMapId);
		}
		public void Deserialize(IDataReader reader)
		{
			State = reader.ReadByte();
			PhenixMapId = reader.ReadDouble();
		}
	}
}
