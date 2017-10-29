using System;
namespace CodebreakV2.Protocol.Types
{
	public class MountClientData
	{
		public Double Id { get; set; }
		public UInt32 Model { get; set; }
		public UInt32[] Ancestor { get; set; }
		public UInt32[] Behaviors { get; set; }
		public String Name { get; set; }
		public Boolean Sex { get; set; }
		public UInt32 OwnerId { get; set; }
		public Int64 Experience { get; set; }
		public Int64 ExperienceForLevel { get; set; }
		public Double ExperienceForNextLevel { get; set; }
		public Byte Level { get; set; }
		public Boolean IsRideable { get; set; }
		public UInt32 MaxPods { get; set; }
		public Boolean IsWild { get; set; }
		public UInt32 Stamina { get; set; }
		public UInt32 StaminaMax { get; set; }
		public UInt32 Maturity { get; set; }
		public UInt32 MaturityForAdult { get; set; }
		public UInt32 Energy { get; set; }
		public UInt32 EnergyMax { get; set; }
		public Int32 Serenity { get; set; }
		public Int32 AggressivityMax { get; set; }
		public UInt32 SerenityMax { get; set; }
		public UInt32 Love { get; set; }
		public UInt32 LoveMax { get; set; }
		public Int32 FecondationTime { get; set; }
		public Boolean IsFecondationReady { get; set; }
		public UInt32 BoostLimiter { get; set; }
		public Double BoostMax { get; set; }
		public Int32 ReproductionCount { get; set; }
		public UInt32 ReproductionCountMax { get; set; }
		public UInt16 HarnessGID { get; set; }
		public Boolean UseHarnessColors { get; set; }
		public ObjectEffectInteger[] EffectList { get; set; }
		public void Serialize(IDataWriter writer)
		{
			UInt32 wrappedBoolean = 0;
			writer.WriteDouble(Id);
			writer.WriteVarInt((Int32)Model);
			for (var i = 0; i < Ancestor.Length; i++)
			{
				writer.WriteInt((Int32)Ancestor[i]);
			}
			for (var i = 0; i < Behaviors.Length; i++)
			{
				writer.WriteInt((Int32)Behaviors[i]);
			}
			writer.WriteUTF(Name);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, Sex);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteInt((Int32)OwnerId);
			writer.WriteVarLong(Experience);
			writer.WriteVarLong(ExperienceForLevel);
			writer.WriteDouble(ExperienceForNextLevel);
			writer.WriteByte(Level);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, IsRideable);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarInt((Int32)MaxPods);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, IsWild);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteVarInt((Int32)Stamina);
			writer.WriteVarInt((Int32)StaminaMax);
			writer.WriteVarInt((Int32)Maturity);
			writer.WriteVarInt((Int32)MaturityForAdult);
			writer.WriteVarInt((Int32)Energy);
			writer.WriteVarInt((Int32)EnergyMax);
			writer.WriteInt(Serenity);
			writer.WriteInt(AggressivityMax);
			writer.WriteVarInt((Int32)SerenityMax);
			writer.WriteVarInt((Int32)Love);
			writer.WriteVarInt((Int32)LoveMax);
			writer.WriteInt(FecondationTime);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, IsFecondationReady);
			writer.WriteByte((Byte)wrappedBoolean);
			writer.WriteInt((Int32)BoostLimiter);
			writer.WriteDouble(BoostMax);
			writer.WriteInt(ReproductionCount);
			writer.WriteVarInt((Int32)ReproductionCountMax);
			writer.WriteVarShort((Int16)HarnessGID);
			wrappedBoolean = 0;
			wrappedBoolean = BooleanByteWrapper.SetFlag(wrappedBoolean, 0, UseHarnessColors);
			writer.WriteByte((Byte)wrappedBoolean);
			for (var i = 0; i < EffectList.Length; i++)
			{
				EffectList[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			UInt32 wrappedBoolean = 0;
			Id = reader.ReadDouble();
			Model = (UInt32)reader.ReadVarInt();
			Ancestor = new UInt32[reader.ReadShort()];
			for (var i = 0; i < Ancestor.Length; i++)
			{
				Ancestor[i] = (UInt32)reader.ReadInt();
			}
			Behaviors = new UInt32[reader.ReadShort()];
			for (var i = 0; i < Behaviors.Length; i++)
			{
				Behaviors[i] = (UInt32)reader.ReadInt();
			}
			Name = reader.ReadUTF();
			wrappedBoolean = (UInt32)reader.ReadByte();
			Sex = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			OwnerId = (UInt32)reader.ReadInt();
			Experience = reader.ReadVarLong();
			ExperienceForLevel = reader.ReadVarLong();
			ExperienceForNextLevel = reader.ReadDouble();
			Level = reader.ReadByte();
			wrappedBoolean = (UInt32)reader.ReadByte();
			IsRideable = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			MaxPods = (UInt32)reader.ReadVarInt();
			wrappedBoolean = (UInt32)reader.ReadByte();
			IsWild = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			Stamina = (UInt32)reader.ReadVarInt();
			StaminaMax = (UInt32)reader.ReadVarInt();
			Maturity = (UInt32)reader.ReadVarInt();
			MaturityForAdult = (UInt32)reader.ReadVarInt();
			Energy = (UInt32)reader.ReadVarInt();
			EnergyMax = (UInt32)reader.ReadVarInt();
			Serenity = reader.ReadInt();
			AggressivityMax = reader.ReadInt();
			SerenityMax = (UInt32)reader.ReadVarInt();
			Love = (UInt32)reader.ReadVarInt();
			LoveMax = (UInt32)reader.ReadVarInt();
			FecondationTime = reader.ReadInt();
			wrappedBoolean = (UInt32)reader.ReadByte();
			IsFecondationReady = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			BoostLimiter = (UInt32)reader.ReadInt();
			BoostMax = reader.ReadDouble();
			ReproductionCount = reader.ReadInt();
			ReproductionCountMax = (UInt32)reader.ReadVarInt();
			HarnessGID = (UInt16)reader.ReadVarShort();
			wrappedBoolean = (UInt32)reader.ReadByte();
			UseHarnessColors = BooleanByteWrapper.GetFlag(wrappedBoolean, 0);
			EffectList = new ObjectEffectInteger[reader.ReadShort()];
			for (var i = 0; i < EffectList.Length; i++)
			{
				(EffectList[i] = new ObjectEffectInteger()).Deserialize(reader);
			}
		}
	}
}
