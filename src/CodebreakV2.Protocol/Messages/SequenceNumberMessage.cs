using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class SequenceNumberMessage
	{
		public UInt16 Number { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort((Int16)Number);
		}
		public void Deserialize(IDataReader reader)
		{
			Number = (UInt16)reader.ReadShort();
		}
	}
}
