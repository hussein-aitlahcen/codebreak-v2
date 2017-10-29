using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PaddockToSellListMessage
	{
		public UInt16 PageIndex { get; set; }
		public UInt16 TotalPage { get; set; }
		public PaddockInformationsForSell[] PaddockList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)PageIndex);
			writer.WriteVarShort((Int16)TotalPage);
			for (var i = 0; i < PaddockList.Length; i++)
			{
				PaddockList[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			PageIndex = (UInt16)reader.ReadVarShort();
			TotalPage = (UInt16)reader.ReadVarShort();
			PaddockList = new PaddockInformationsForSell[reader.ReadShort()];
			for (var i = 0; i < PaddockList.Length; i++)
			{
				(PaddockList[i] = new PaddockInformationsForSell()).Deserialize(reader);
			}
		}
	}
}
