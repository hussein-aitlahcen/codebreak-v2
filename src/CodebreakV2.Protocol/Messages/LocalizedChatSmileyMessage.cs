using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class LocalizedChatSmileyMessage : ChatSmileyMessage
	{
		public UInt16 CellId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)CellId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CellId = (UInt16)reader.ReadVarShort();
		}
	}
}
