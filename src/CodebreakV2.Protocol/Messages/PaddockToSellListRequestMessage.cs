using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PaddockToSellListRequestMessage
	{
		public UInt16 PageIndex { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)PageIndex);
		}
		public void Deserialize(IDataReader reader)
		{
			PageIndex = (UInt16)reader.ReadVarShort();
		}
	}
}
