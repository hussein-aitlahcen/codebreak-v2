using System;
namespace CodebreakV2.Protocol.Types
{
	public class EntityDispositionInformations
	{
		public Int16 CellId { get; set; }
		public Byte Direction { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteShort(CellId);
			writer.WriteByte(Direction);
		}
		public void Deserialize(IDataReader reader)
		{
			CellId = reader.ReadShort();
			Direction = reader.ReadByte();
		}
	}
}
