using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeObjectsRemovedMessage : ExchangeObjectMessage
	{
		public UInt32[] ObjectUID { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < ObjectUID.Length; i++)
			{
				writer.WriteVarInt((Int32)ObjectUID[i]);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ObjectUID = new UInt32[reader.ReadShort()];
			for (var i = 0; i < ObjectUID.Length; i++)
			{
				ObjectUID[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
