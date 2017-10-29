using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameActionMarkedCell
	{
		public UInt16 CellId { get; set; }
		public SByte ZoneSize { get; set; }
		public Int32 CellColor { get; set; }
		public SByte CellsType { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)CellId);
			writer.WriteByte((Byte)ZoneSize);
			writer.WriteInt(CellColor);
			writer.WriteByte((Byte)CellsType);
		}
		public void Deserialize(IDataReader reader)
		{
			CellId = (UInt16)reader.ReadVarShort();
			ZoneSize = (SByte)reader.ReadByte();
			CellColor = reader.ReadInt();
			CellsType = (SByte)reader.ReadByte();
		}
	}
}
