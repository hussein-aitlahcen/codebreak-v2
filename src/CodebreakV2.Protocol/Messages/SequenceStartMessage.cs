using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SequenceStartMessage
	{
		public SByte SequenceType { get; set; }
		public Double AuthorId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte((Byte)SequenceType);
			writer.WriteDouble(AuthorId);
		}
		public void Deserialize(IDataReader reader)
		{
			SequenceType = (SByte)reader.ReadByte();
			AuthorId = reader.ReadDouble();
		}
	}
}
