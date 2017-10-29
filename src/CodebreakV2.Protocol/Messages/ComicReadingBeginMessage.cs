using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ComicReadingBeginMessage
	{
		public UInt16 ComicId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ComicId);
		}
		public void Deserialize(IDataReader reader)
		{
			ComicId = (UInt16)reader.ReadVarShort();
		}
	}
}
