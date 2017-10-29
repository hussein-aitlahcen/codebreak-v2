using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class HouseBuyResultMessage
	{
		public UInt32 HouseId { get; set; }
		public UInt32 InstanceId { get; set; }
		public Boolean SecondHand { get; set; }
		public Boolean Bought { get; set; }
		public Int64 RealPrice { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			writer.WriteVarInt((Int32)HouseId);
			writer.WriteInt((Int32)InstanceId);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, SecondHand);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, Bought);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarLong(RealPrice);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			HouseId = (UInt32)reader.ReadVarInt();
			InstanceId = (UInt32)reader.ReadInt();
			wrappedBoolean = (UInt32)reader.ReadByte();
			SecondHand = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			Bought = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			RealPrice = reader.ReadVarLong();
		}
	}
}
