using System;
namespace CodebreakV2.Protocol.Types
{
	public class ContentPart
	{
		public String Id { get; set; }
		public Byte State { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Id);
			writer.WriteByte(State);
		}
		public void Deserialize(IDataReader reader)
		{
			Id = reader.ReadUTF();
			State = reader.ReadByte();
		}
	}
}
