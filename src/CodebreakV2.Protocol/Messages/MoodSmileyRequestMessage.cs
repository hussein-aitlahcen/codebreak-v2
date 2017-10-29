using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MoodSmileyRequestMessage
	{
		public UInt16 SmileyId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SmileyId);
		}
		public void Deserialize(IDataReader reader)
		{
			SmileyId = (UInt16)reader.ReadVarShort();
		}
	}
}
