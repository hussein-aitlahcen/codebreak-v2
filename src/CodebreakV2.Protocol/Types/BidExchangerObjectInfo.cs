using System;
namespace CodebreakV2.Protocol.Types
{
	public class BidExchangerObjectInfo
	{
		public UInt32 ObjectUID { get; set; }
		public ObjectEffect[] Effects { get; set; }
		public Int64[] Prices { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ObjectUID);
			for (var i = 0; i < Effects.Length; i++)
			{
				Effects[i].Serialize(writer);
			}
			for (var i = 0; i < Prices.Length; i++)
			{
				writer.WriteVarLong(Prices[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectUID = (UInt32)reader.ReadVarInt();
			Effects = new ObjectEffect[reader.ReadShort()];
			for (var i = 0; i < Effects.Length; i++)
			{
				(Effects[i] = new ObjectEffect()).Deserialize(reader);
			}
			Prices = new Int64[reader.ReadShort()];
			for (var i = 0; i < Prices.Length; i++)
			{
				Prices[i] = reader.ReadVarLong();
			}
		}
	}
}
