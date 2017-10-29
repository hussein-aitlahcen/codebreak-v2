using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SequenceEndMessage
	{
		public UInt16 ActionId { get; set; }
		public Double AuthorId { get; set; }
		public SByte SequenceType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ActionId);
			writer.WriteDouble(AuthorId);
			writer.WriteByte((Byte)SequenceType);
		}
		public void Deserialize(IDataReader reader)
		{
			ActionId = (UInt16)reader.ReadVarShort();
			AuthorId = reader.ReadDouble();
			SequenceType = (SByte)reader.ReadByte();
		}
	}
}
