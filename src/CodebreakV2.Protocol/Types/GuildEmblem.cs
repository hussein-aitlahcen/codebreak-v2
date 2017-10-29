using System;
namespace CodebreakV2.Protocol.Types
{
	public class GuildEmblem
	{
		public UInt16 SymbolShape { get; set; }
		public Int32 SymbolColor { get; set; }
		public Byte BackgroundShape { get; set; }
		public Int32 BackgroundColor { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SymbolShape);
			writer.WriteInt(SymbolColor);
			writer.WriteByte(BackgroundShape);
			writer.WriteInt(BackgroundColor);
		}
		public void Deserialize(IDataReader reader)
		{
			SymbolShape = (UInt16)reader.ReadVarShort();
			SymbolColor = reader.ReadInt();
			BackgroundShape = reader.ReadByte();
			BackgroundColor = reader.ReadInt();
		}
	}
}
