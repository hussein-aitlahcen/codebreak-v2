using System;
namespace CodebreakV2.Protocol.Types
{
	public class PlayerStatus
	{
		public Byte StatusId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(StatusId);
		}
		public void Deserialize(IDataReader reader)
		{
			StatusId = reader.ReadByte();
		}
	}
}
