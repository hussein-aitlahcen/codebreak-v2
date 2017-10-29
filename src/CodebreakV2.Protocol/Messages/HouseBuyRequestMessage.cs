using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HouseBuyRequestMessage
	{
		public Int64 ProposedPrice { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(ProposedPrice);
		}
		public void Deserialize(IDataReader reader)
		{
			ProposedPrice = reader.ReadVarLong();
		}
	}
}
