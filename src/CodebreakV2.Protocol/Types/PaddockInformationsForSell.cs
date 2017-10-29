using System;
namespace CodebreakV2.Protocol.Types
{
	public class PaddockInformationsForSell
	{
		public String GuildOwner { get; set; }
		public Int16 WorldX { get; set; }
		public Int16 WorldY { get; set; }
		public UInt16 SubAreaId { get; set; }
		public SByte NbMount { get; set; }
		public SByte NbObject { get; set; }
		public Int64 Price { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(GuildOwner);
			writer.WriteShort(WorldX);
			writer.WriteShort(WorldY);
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteByte((Byte)NbMount);
			writer.WriteByte((Byte)NbObject);
			writer.WriteVarLong(Price);
		}
		public void Deserialize(IDataReader reader)
		{
			GuildOwner = reader.ReadUTF();
			WorldX = reader.ReadShort();
			WorldY = reader.ReadShort();
			SubAreaId = (UInt16)reader.ReadVarShort();
			NbMount = (SByte)reader.ReadByte();
			NbObject = (SByte)reader.ReadByte();
			Price = reader.ReadVarLong();
		}
	}
}
