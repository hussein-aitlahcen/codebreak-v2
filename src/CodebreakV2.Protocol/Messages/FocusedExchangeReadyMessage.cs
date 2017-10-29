using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class FocusedExchangeReadyMessage : ExchangeReadyMessage
	{
		public UInt32 FocusActionId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)FocusActionId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			FocusActionId = (UInt32)reader.ReadVarInt();
		}
	}
}
