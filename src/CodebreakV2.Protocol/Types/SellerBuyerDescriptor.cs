using System;
namespace CodebreakV2.Protocol.Types
{
	public class SellerBuyerDescriptor
	{
		public UInt32[] Quantities { get; set; }
		public UInt32[] Types { get; set; }
		public Single TaxPercentage { get; set; }
		public Single TaxModificationPercentage { get; set; }
		public Byte MaxItemLevel { get; set; }
		public UInt32 MaxItemPerAccount { get; set; }
		public Int32 NpcContextualId { get; set; }
		public UInt16 UnsoldDelay { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Quantities.Length; i++)
			{
				writer.WriteVarInt((Int32)Quantities[i]);
			}
			for (var i = 0; i < Types.Length; i++)
			{
				writer.WriteVarInt((Int32)Types[i]);
			}
			writer.WriteFloat(TaxPercentage);
			writer.WriteFloat(TaxModificationPercentage);
			writer.WriteByte(MaxItemLevel);
			writer.WriteVarInt((Int32)MaxItemPerAccount);
			writer.WriteInt(NpcContextualId);
			writer.WriteVarShort((Int16)UnsoldDelay);
		}
		public void Deserialize(IDataReader reader)
		{
			Quantities = new UInt32[reader.ReadShort()];
			for (var i = 0; i < Quantities.Length; i++)
			{
				Quantities[i] = (UInt32)reader.ReadVarInt();
			}
			Types = new UInt32[reader.ReadShort()];
			for (var i = 0; i < Types.Length; i++)
			{
				Types[i] = (UInt32)reader.ReadVarInt();
			}
			TaxPercentage = reader.ReadFloat();
			TaxModificationPercentage = reader.ReadFloat();
			MaxItemLevel = reader.ReadByte();
			MaxItemPerAccount = (UInt32)reader.ReadVarInt();
			NpcContextualId = reader.ReadInt();
			UnsoldDelay = (UInt16)reader.ReadVarShort();
		}
	}
}
