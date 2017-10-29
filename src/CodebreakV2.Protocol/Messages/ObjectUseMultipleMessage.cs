using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ObjectUseMultipleMessage : ObjectUseMessage
	{
		public UInt32 Quantity { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)Quantity);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Quantity = (UInt32)reader.ReadVarInt();
		}
	}
}
