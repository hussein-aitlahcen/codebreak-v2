using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MoodSmileyResultMessage
	{
		public Byte ResultCode { get; set; }
		public UInt16 SmileyId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte(ResultCode);
			writer.WriteVarShort((Int16)SmileyId);
		}
		public void Deserialize(IDataReader reader)
		{
			ResultCode = reader.ReadByte();
			SmileyId = (UInt16)reader.ReadVarShort();
		}
	}
}
