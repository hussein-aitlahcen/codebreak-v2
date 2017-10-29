using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class MailStatusMessage
	{
		public UInt16 Unread { get; set; }
		public UInt16 Total { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)Unread);
			writer.WriteVarShort((Int16)Total);
		}
		public void Deserialize(IDataReader reader)
		{
			Unread = (UInt16)reader.ReadVarShort();
			Total = (UInt16)reader.ReadVarShort();
		}
	}
}
