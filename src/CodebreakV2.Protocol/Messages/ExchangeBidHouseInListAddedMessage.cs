using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ExchangeBidHouseInListAddedMessage
	{
		public Int32 ItemUID { get; set; }
		public Int32 ObjGenericId { get; set; }
		public ObjectEffect[] Effects { get; set; }
		public Int64[] Prices { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteInt(ItemUID);
			writer.WriteInt(ObjGenericId);
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
			ItemUID = reader.ReadInt();
			ObjGenericId = reader.ReadInt();
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
