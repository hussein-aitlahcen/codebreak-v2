using System;
namespace CodebreakV2.Protocol.Types
{
	public class MapObstacle
	{
		public UInt16 ObstacleCellId { get; set; }
		public Byte State { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ObstacleCellId);
			writer.WriteByte(State);
		}
		public void Deserialize(IDataReader reader)
		{
			ObstacleCellId = (UInt16)reader.ReadVarShort();
			State = reader.ReadByte();
		}
	}
}
