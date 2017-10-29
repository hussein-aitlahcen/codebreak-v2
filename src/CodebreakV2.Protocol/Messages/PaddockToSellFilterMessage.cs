using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PaddockToSellFilterMessage
	{
		public Int32 AreaId { get; set; }
		public SByte AtLeastNbMount { get; set; }
		public SByte AtLeastNbMachine { get; set; }
		public Int64 MaxPrice { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(AreaId);
			writer.WriteByte((Byte)AtLeastNbMount);
			writer.WriteByte((Byte)AtLeastNbMachine);
			writer.WriteVarLong(MaxPrice);
		}
		public void Deserialize(IDataReader reader)
		{
			AreaId = reader.ReadInt();
			AtLeastNbMount = (SByte)reader.ReadByte();
			AtLeastNbMachine = (SByte)reader.ReadByte();
			MaxPrice = reader.ReadVarLong();
		}
	}
}
