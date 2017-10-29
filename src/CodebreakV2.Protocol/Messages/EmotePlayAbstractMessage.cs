using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class EmotePlayAbstractMessage
	{
		public Byte EmoteId { get; set; }
		public Double EmoteStartTime { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(EmoteId);
			writer.WriteDouble(EmoteStartTime);
		}
		public void Deserialize(IDataReader reader)
		{
			EmoteId = reader.ReadByte();
			EmoteStartTime = reader.ReadDouble();
		}
	}
}
