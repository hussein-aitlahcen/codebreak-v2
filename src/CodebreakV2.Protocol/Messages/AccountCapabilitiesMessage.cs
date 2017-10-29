using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class AccountCapabilitiesMessage
	{
		public UInt32 AccountId { get; set; }
		public Boolean TutorialAvailable { get; set; }
		public UInt32 BreedsVisible { get; set; }
		public UInt32 BreedsAvailable { get; set; }
		public SByte Status { get; set; }
		public Boolean CanCreateNewCharacter { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			writer.WriteInt((Int32)AccountId);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, TutorialAvailable);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarInt((Int32)BreedsVisible);
			writer.WriteVarInt((Int32)BreedsAvailable);
			writer.WriteByte((Byte)Status);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, CanCreateNewCharacter);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			AccountId = (UInt32)reader.ReadInt();
			wrappedBoolean = (UInt32)reader.ReadByte();
			TutorialAvailable = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			BreedsVisible = (UInt32)reader.ReadVarInt();
			BreedsAvailable = (UInt32)reader.ReadVarInt();
			Status = (SByte)reader.ReadByte();
			wrappedBoolean = (UInt32)reader.ReadByte();
			CanCreateNewCharacter = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
		}
	}
}
