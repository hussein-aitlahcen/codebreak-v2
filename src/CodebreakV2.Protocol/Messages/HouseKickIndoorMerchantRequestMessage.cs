using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HouseKickIndoorMerchantRequestMessage
	{
		public UInt16 CellId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)CellId);
		}
		public void Deserialize(IDataReader reader)
		{
			CellId = (UInt16)reader.ReadVarShort();
		}
	}
}
