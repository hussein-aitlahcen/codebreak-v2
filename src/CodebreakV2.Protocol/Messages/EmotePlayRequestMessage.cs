using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class EmotePlayRequestMessage
	{
		public Byte EmoteId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(EmoteId);
		}
		public void Deserialize(IDataReader reader)
		{
			EmoteId = reader.ReadByte();
		}
	}
}
