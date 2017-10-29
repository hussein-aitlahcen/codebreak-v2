using System;
namespace CodebreakV2.Protocol.Types
{
	public class DecraftedItemStackInfo
	{
		public UInt32 ObjectUID { get; set; }
		public Single BonusMin { get; set; }
		public Single BonusMax { get; set; }
		public UInt16[] RunesId { get; set; }
		public UInt32[] RunesQty { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)ObjectUID);
			writer.WriteFloat(BonusMin);
			writer.WriteFloat(BonusMax);
			for (var i = 0; i < RunesId.Length; i++)
			{
				writer.WriteVarShort((Int16)RunesId[i]);
			}
			for (var i = 0; i < RunesQty.Length; i++)
			{
				writer.WriteVarInt((Int32)RunesQty[i]);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			ObjectUID = (UInt32)reader.ReadVarInt();
			BonusMin = reader.ReadFloat();
			BonusMax = reader.ReadFloat();
			RunesId = new UInt16[reader.ReadShort()];
			for (var i = 0; i < RunesId.Length; i++)
			{
				RunesId[i] = (UInt16)reader.ReadVarShort();
			}
			RunesQty = new UInt32[reader.ReadShort()];
			for (var i = 0; i < RunesQty.Length; i++)
			{
				RunesQty[i] = (UInt32)reader.ReadVarInt();
			}
		}
	}
}
