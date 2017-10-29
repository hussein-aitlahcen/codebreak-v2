using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangePodsModifiedMessage : ExchangeObjectMessage
	{
		public UInt32 CurrentWeight { get; set; }
		public UInt32 MaxWeight { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)CurrentWeight);
			writer.WriteVarInt((Int32)MaxWeight);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CurrentWeight = (UInt32)reader.ReadVarInt();
			MaxWeight = (UInt32)reader.ReadVarInt();
		}
	}
}
