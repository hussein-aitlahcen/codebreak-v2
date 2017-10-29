using System;
namespace CodebreakV2.Protocol.Types
{
	public class HavenBagFurnitureInformation
	{
		public UInt16 CellId { get; set; }
		public Int32 FunitureId { get; set; }
		public Byte Orientation { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)CellId);
			writer.WriteInt(FunitureId);
			writer.WriteByte(Orientation);
		}
		public void Deserialize(IDataReader reader)
		{
			CellId = (UInt16)reader.ReadVarShort();
			FunitureId = reader.ReadInt();
			Orientation = reader.ReadByte();
		}
	}
}
