using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PurchasableDialogMessage
	{
		public Boolean BuyOrSell { get; set; }
		public Double PurchasableId { get; set; }
		public UInt32 PurchasableInstanceId { get; set; }
		public Boolean SecondHand { get; set; }
		public Int64 Price { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, BuyOrSell);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteDouble(PurchasableId);
			writer.WriteInt((Int32)PurchasableInstanceId);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, SecondHand);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarLong(Price);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			wrappedBoolean = (UInt32)reader.ReadByte();
			BuyOrSell = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			PurchasableId = reader.ReadDouble();
			PurchasableInstanceId = (UInt32)reader.ReadInt();
			wrappedBoolean = (UInt32)reader.ReadByte();
			SecondHand = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			Price = reader.ReadVarLong();
		}
	}
}
