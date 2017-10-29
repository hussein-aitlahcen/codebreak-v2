using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class RoomAvailableUpdateMessage
	{
		public Byte NbRoom { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(NbRoom);
		}
		public void Deserialize(IDataReader reader)
		{
			NbRoom = reader.ReadByte();
		}
	}
}
