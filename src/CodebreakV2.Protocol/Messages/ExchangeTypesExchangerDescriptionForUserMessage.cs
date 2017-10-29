using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeTypesExchangerDescriptionForUserMessage
	{
		public UInt32[] TypeDescription { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < TypeDescription.Length; i++)
			{
				writer.WriteVarInt((Int32)TypeDescription[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			TypeDescription = new UInt32[reader.ReadShort()];
			for (var i = 0; i < TypeDescription.Length; i++)
			{
				TypeDescription[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
