using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameMapChangeOrientationRequestMessage
	{
		public Byte Direction { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(Direction);
		}
		public void Deserialize(IDataReader reader)
		{
			Direction = reader.ReadByte();
		}
	}
}
