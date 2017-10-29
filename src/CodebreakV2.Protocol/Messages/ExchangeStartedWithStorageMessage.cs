using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartedWithStorageMessage : ExchangeStartedMessage
	{
		public UInt32 StorageMaxSlot { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)StorageMaxSlot);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			StorageMaxSlot = (UInt32)reader.ReadVarInt();
		}
	}
}
