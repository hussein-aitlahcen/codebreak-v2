using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeHandleMountsStableMessage
	{
		public SByte ActionType { get; set; }
		public UInt32[] RidesId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteByte((Byte)ActionType);
			for (var i = 0; i < RidesId.Length; i++)
			{
				writer.WriteVarInt((Int32)RidesId[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ActionType = (SByte)reader.ReadByte();
			RidesId = new UInt32[reader.ReadShort()];
			for (var i = 0; i < RidesId.Length; i++)
			{
				RidesId[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
