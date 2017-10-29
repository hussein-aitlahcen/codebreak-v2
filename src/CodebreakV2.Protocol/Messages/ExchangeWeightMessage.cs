using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeWeightMessage
	{
		public UInt32 CurrentWeight { get; set; }
		public UInt32 MaxWeight { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)CurrentWeight);
			writer.WriteVarInt((Int32)MaxWeight);
		}
		public void Deserialize(IDataReader reader)
		{
			CurrentWeight = (UInt32)reader.ReadVarInt();
			MaxWeight = (UInt32)reader.ReadVarInt();
		}
	}
}
