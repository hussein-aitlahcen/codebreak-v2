using System;
namespace CodebreakV2.Protocol.Types
{
	public class HouseInstanceInformations
	{
		public UInt32 InstanceId { get; set; }
		public Boolean SecondHand { get; set; }
		public Boolean IsLocked { get; set; }
		public String OwnerName { get; set; }
		public Int64 Price { get; set; }
		public Boolean IsSaleLocked { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			writer.WriteInt((Int32)InstanceId);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, SecondHand);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, IsLocked);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteUTF(OwnerName);
			writer.WriteVarLong(Price);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, IsSaleLocked);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			InstanceId = (UInt32)reader.ReadInt();
			wrappedBoolean = (UInt32)reader.ReadByte();
			SecondHand = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			IsLocked = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
			OwnerName = reader.ReadUTF();
			Price = reader.ReadVarLong();
			wrappedBoolean = (UInt32)reader.ReadByte();
			IsSaleLocked = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
		}
	}
}
