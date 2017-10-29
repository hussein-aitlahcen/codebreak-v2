using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameFightNewWaveMessage
	{
		public Byte Id { get; set; }
		public Byte TeamId { get; set; }
		public Int16 NbTurnBeforeNextWave { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Id);
			writer.WriteByte(TeamId);
			writer.WriteShort(NbTurnBeforeNextWave);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadByte();
			TeamId = reader.ReadByte();
			NbTurnBeforeNextWave = reader.ReadShort();
		}
	}
}
