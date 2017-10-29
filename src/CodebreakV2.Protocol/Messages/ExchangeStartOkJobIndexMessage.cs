using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeStartOkJobIndexMessage
	{
		public UInt32[] Jobs { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Jobs.Length; i++)
			{
				writer.WriteVarInt((Int32)Jobs[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Jobs = new UInt32[reader.ReadShort()];
			for (var i = 0; i < Jobs.Length; i++)
			{
				Jobs[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
