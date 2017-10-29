using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeOnHumanVendorRequestMessage
	{
		public Int64 HumanVendorId { get; set; }
		public UInt16 HumanVendorCell { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(HumanVendorId);
			writer.WriteVarShort((Int16)HumanVendorCell);
		}
		public void Deserialize(IDataReader reader)
		{
			HumanVendorId = reader.ReadVarLong();
			HumanVendorCell = (UInt16)reader.ReadVarShort();
		}
	}
}
