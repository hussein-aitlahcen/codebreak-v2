using System;
namespace CodebreakV2.Protocol.Types
{
	public class ActorOrientation
	{
		public Double Id { get; set; }
		public Byte Direction { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(Id);
			writer.WriteByte(Direction);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadDouble();
			Direction = reader.ReadByte();
		}
	}
}
