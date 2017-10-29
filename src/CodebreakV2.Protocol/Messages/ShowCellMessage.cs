using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ShowCellMessage
	{
		public Double SourceId { get; set; }
		public UInt16 CellId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(SourceId);
			writer.WriteVarShort((Int16)CellId);
		}
		public void Deserialize(IDataReader reader)
		{
			SourceId = reader.ReadDouble();
			CellId = (UInt16)reader.ReadVarShort();
		}
	}
}
