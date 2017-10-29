using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PaddockMoveItemRequestMessage
	{
		public UInt16 OldCellId { get; set; }
		public UInt16 NewCellId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)OldCellId);
			writer.WriteVarShort((Int16)NewCellId);
		}
		public void Deserialize(IDataReader reader)
		{
			OldCellId = (UInt16)reader.ReadVarShort();
			NewCellId = (UInt16)reader.ReadVarShort();
		}
	}
}
