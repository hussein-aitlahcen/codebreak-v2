using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeMountsStableRemoveMessage
	{
		public Int32[] MountsId { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < MountsId.Length; i++)
			{
				writer.WriteVarInt(MountsId[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			MountsId = new Int32[reader.ReadShort()];
			for (var i = 0; i < MountsId.Length; i++)
			{
				MountsId[i] = reader.ReadVarInt();
			}
		}
	}
}
