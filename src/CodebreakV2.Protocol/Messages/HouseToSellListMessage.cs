using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HouseToSellListMessage
	{
		public UInt16 PageIndex { get; set; }
		public UInt16 TotalPage { get; set; }
		public HouseInformationsForSell[] HouseList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)PageIndex);
			writer.WriteVarShort((Int16)TotalPage);
			for (var i = 0; i < HouseList.Length; i++)
			{
				HouseList[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PageIndex = (UInt16)reader.ReadVarShort();
			TotalPage = (UInt16)reader.ReadVarShort();
			HouseList = new HouseInformationsForSell[reader.ReadShort()];
			for (var i = 0; i < HouseList.Length; i++)
			{
				(HouseList[i] = new HouseInformationsForSell()).Deserialize(reader);
			}
		}
	}
}
