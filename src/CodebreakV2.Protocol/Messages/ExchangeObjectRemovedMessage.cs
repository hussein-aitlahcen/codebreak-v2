using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeObjectRemovedMessage : ExchangeObjectMessage
	{
		public UInt32 ObjectUID { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((Int32)ObjectUID);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ObjectUID = (UInt32)reader.ReadVarInt();
		}
	}
}
