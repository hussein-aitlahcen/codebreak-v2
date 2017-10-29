using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeObjectTransfertListFromInvMessage
	{
		public UInt32[] Ids { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Ids.Length; i++)
			{
				writer.WriteVarInt((Int32)Ids[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Ids = new UInt32[reader.ReadShort()];
			for (var i = 0; i < Ids.Length; i++)
			{
				Ids[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
