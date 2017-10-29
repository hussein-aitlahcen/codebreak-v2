using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightMinimalStats
	{
		public UInt32 LifePoints { get; set; }
		public UInt32 MaxLifePoints { get; set; }
		public UInt32 BaseMaxLifePoints { get; set; }
		public UInt32 PermanentDamagePercent { get; set; }
		public UInt32 ShieldPoints { get; set; }
		public Int16 ActionPoints { get; set; }
		public Int16 MaxActionPoints { get; set; }
		public Int16 MovementPoints { get; set; }
		public Int16 MaxMovementPoints { get; set; }
		public Double Summoner { get; set; }
		public Boolean Summoned { get; set; }
		public Int16 NeutralElementResistPercent { get; set; }
		public Int16 EarthElementResistPercent { get; set; }
		public Int16 WaterElementResistPercent { get; set; }
		public Int16 AirElementResistPercent { get; set; }
		public Int16 FireElementResistPercent { get; set; }
		public Int16 NeutralElementReduction { get; set; }
		public Int16 EarthElementReduction { get; set; }
		public Int16 WaterElementReduction { get; set; }
		public Int16 AirElementReduction { get; set; }
		public Int16 FireElementReduction { get; set; }
		public Int16 CriticalDamageFixedResist { get; set; }
		public Int16 PushDamageFixedResist { get; set; }
		public Int16 PvpNeutralElementResistPercent { get; set; }
		public Int16 PvpEarthElementResistPercent { get; set; }
		public Int16 PvpWaterElementResistPercent { get; set; }
		public Int16 PvpAirElementResistPercent { get; set; }
		public Int16 PvpFireElementResistPercent { get; set; }
		public Int16 PvpNeutralElementReduction { get; set; }
		public Int16 PvpEarthElementReduction { get; set; }
		public Int16 PvpWaterElementReduction { get; set; }
		public Int16 PvpAirElementReduction { get; set; }
		public Int16 PvpFireElementReduction { get; set; }
		public UInt16 DodgePALostProbability { get; set; }
		public UInt16 DodgePMLostProbability { get; set; }
		public Int16 TackleBlock { get; set; }
		public Int16 TackleEvade { get; set; }
		public Int16 FixedDamageReflection { get; set; }
		public Byte InvisibilityState { get; set; }
		public UInt16 MeleeDamageReceivedPercent { get; set; }
		public UInt16 RangedDamageReceivedPercent { get; set; }
		public UInt16 WeaponDamageReceivedPercent { get; set; }
		public UInt16 SpellDamageReceivedPercent { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((Int32)LifePoints);
			writer.WriteVarInt((Int32)MaxLifePoints);
			writer.WriteVarInt((Int32)BaseMaxLifePoints);
			writer.WriteVarInt((Int32)PermanentDamagePercent);
			writer.WriteVarInt((Int32)ShieldPoints);
			writer.WriteVarShort(ActionPoints);
			writer.WriteVarShort(MaxActionPoints);
			writer.WriteVarShort(MovementPoints);
			writer.WriteVarShort(MaxMovementPoints);
			writer.WriteDouble(Summoner);
			writer.WriteBoolean(Summoned);
			writer.WriteVarShort(NeutralElementResistPercent);
			writer.WriteVarShort(EarthElementResistPercent);
			writer.WriteVarShort(WaterElementResistPercent);
			writer.WriteVarShort(AirElementResistPercent);
			writer.WriteVarShort(FireElementResistPercent);
			writer.WriteVarShort(NeutralElementReduction);
			writer.WriteVarShort(EarthElementReduction);
			writer.WriteVarShort(WaterElementReduction);
			writer.WriteVarShort(AirElementReduction);
			writer.WriteVarShort(FireElementReduction);
			writer.WriteVarShort(CriticalDamageFixedResist);
			writer.WriteVarShort(PushDamageFixedResist);
			writer.WriteVarShort(PvpNeutralElementResistPercent);
			writer.WriteVarShort(PvpEarthElementResistPercent);
			writer.WriteVarShort(PvpWaterElementResistPercent);
			writer.WriteVarShort(PvpAirElementResistPercent);
			writer.WriteVarShort(PvpFireElementResistPercent);
			writer.WriteVarShort(PvpNeutralElementReduction);
			writer.WriteVarShort(PvpEarthElementReduction);
			writer.WriteVarShort(PvpWaterElementReduction);
			writer.WriteVarShort(PvpAirElementReduction);
			writer.WriteVarShort(PvpFireElementReduction);
			writer.WriteVarShort((Int16)DodgePALostProbability);
			writer.WriteVarShort((Int16)DodgePMLostProbability);
			writer.WriteVarShort(TackleBlock);
			writer.WriteVarShort(TackleEvade);
			writer.WriteVarShort(FixedDamageReflection);
			writer.WriteByte(InvisibilityState);
			writer.WriteVarShort((Int16)MeleeDamageReceivedPercent);
			writer.WriteVarShort((Int16)RangedDamageReceivedPercent);
			writer.WriteVarShort((Int16)WeaponDamageReceivedPercent);
			writer.WriteVarShort((Int16)SpellDamageReceivedPercent);
		}
		public void Deserialize(IDataReader reader)
		{
			LifePoints = (UInt32)reader.ReadVarInt();
			MaxLifePoints = (UInt32)reader.ReadVarInt();
			BaseMaxLifePoints = (UInt32)reader.ReadVarInt();
			PermanentDamagePercent = (UInt32)reader.ReadVarInt();
			ShieldPoints = (UInt32)reader.ReadVarInt();
			ActionPoints = reader.ReadVarShort();
			MaxActionPoints = reader.ReadVarShort();
			MovementPoints = reader.ReadVarShort();
			MaxMovementPoints = reader.ReadVarShort();
			Summoner = reader.ReadDouble();
			Summoned = reader.ReadBoolean();
			NeutralElementResistPercent = reader.ReadVarShort();
			EarthElementResistPercent = reader.ReadVarShort();
			WaterElementResistPercent = reader.ReadVarShort();
			AirElementResistPercent = reader.ReadVarShort();
			FireElementResistPercent = reader.ReadVarShort();
			NeutralElementReduction = reader.ReadVarShort();
			EarthElementReduction = reader.ReadVarShort();
			WaterElementReduction = reader.ReadVarShort();
			AirElementReduction = reader.ReadVarShort();
			FireElementReduction = reader.ReadVarShort();
			CriticalDamageFixedResist = reader.ReadVarShort();
			PushDamageFixedResist = reader.ReadVarShort();
			PvpNeutralElementResistPercent = reader.ReadVarShort();
			PvpEarthElementResistPercent = reader.ReadVarShort();
			PvpWaterElementResistPercent = reader.ReadVarShort();
			PvpAirElementResistPercent = reader.ReadVarShort();
			PvpFireElementResistPercent = reader.ReadVarShort();
			PvpNeutralElementReduction = reader.ReadVarShort();
			PvpEarthElementReduction = reader.ReadVarShort();
			PvpWaterElementReduction = reader.ReadVarShort();
			PvpAirElementReduction = reader.ReadVarShort();
			PvpFireElementReduction = reader.ReadVarShort();
			DodgePALostProbability = (UInt16)reader.ReadVarShort();
			DodgePMLostProbability = (UInt16)reader.ReadVarShort();
			TackleBlock = reader.ReadVarShort();
			TackleEvade = reader.ReadVarShort();
			FixedDamageReflection = reader.ReadVarShort();
			InvisibilityState = reader.ReadByte();
			MeleeDamageReceivedPercent = (UInt16)reader.ReadVarShort();
			RangedDamageReceivedPercent = (UInt16)reader.ReadVarShort();
			WeaponDamageReceivedPercent = (UInt16)reader.ReadVarShort();
			SpellDamageReceivedPercent = (UInt16)reader.ReadVarShort();
		}
	}
}
