using System;
namespace CodebreakV2.Protocol.Types
{
	public class TreasureHuntFlag
	{
		public Double MapId { get; set; }
		public Byte State { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(MapId);
			writer.WriteByte(State);
		}
		public void Deserialize(IDataReader reader)
		{
			MapId = reader.ReadDouble();
			State = reader.ReadByte();
		}
	}
}
