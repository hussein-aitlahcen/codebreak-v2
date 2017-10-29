using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HouseToSellFilterMessage
	{
		public Int32 AreaId { get; set; }
		public Byte AtLeastNbRoom { get; set; }
		public Byte AtLeastNbChest { get; set; }
		public UInt16 SkillRequested { get; set; }
		public Int64 MaxPrice { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(AreaId);
			writer.WriteByte(AtLeastNbRoom);
			writer.WriteByte(AtLeastNbChest);
			writer.WriteVarShort((Int16)SkillRequested);
			writer.WriteVarLong(MaxPrice);
		}
		public void Deserialize(IDataReader reader)
		{
			AreaId = reader.ReadInt();
			AtLeastNbRoom = reader.ReadByte();
			AtLeastNbChest = reader.ReadByte();
			SkillRequested = (UInt16)reader.ReadVarShort();
			MaxPrice = reader.ReadVarLong();
		}
	}
}
