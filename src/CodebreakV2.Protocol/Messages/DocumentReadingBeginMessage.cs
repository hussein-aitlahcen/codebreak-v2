using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class DocumentReadingBeginMessage
	{
		public UInt16 DocumentId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)DocumentId);
		}
		public void Deserialize(IDataReader reader)
		{
			DocumentId = (UInt16)reader.ReadVarShort();
		}
	}
}
