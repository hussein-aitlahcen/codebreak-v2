using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightFighterLightInformations
	{
		public Double Id { get; set; }
		public Byte Wave { get; set; }
		public UInt16 Level { get; set; }
		public SByte Breed { get; set; }
		public Boolean Sex { get; set; }
		public Boolean Alive { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			writer.WriteDouble(Id);
			writer.WriteByte(Wave);
			writer.WriteVarShort((Int16)Level);
			writer.WriteByte((Byte)Breed);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Sex);
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 1, Alive);
			writer.WriteByte((Byte)wrappedBoolean);
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			Id = reader.ReadDouble();
			Wave = reader.ReadByte();
			Level = (UInt16)reader.ReadVarShort();
			Breed = (SByte)reader.ReadByte();
			wrappedBoolean = (UInt32)reader.ReadByte();
			Sex = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			Alive = BooleanByteWrapper.GetFlag(wrappedBoolean, 1);
		}
	}
}
