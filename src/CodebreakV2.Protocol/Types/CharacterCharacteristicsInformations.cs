using System;
namespace CodebreakV2.Protocol.Types
{
	public class CharacterCharacteristicsInformations
	{
		public Int64 Experience { get; set; }
		public Int64 ExperienceLevelFloor { get; set; }
		public Int64 ExperienceNextLevelFloor { get; set; }
		public Int64 ExperienceBonusLimit { get; set; }
		public Int64 Kamas { get; set; }
		public UInt16 StatsPoints { get; set; }
		public UInt16 AdditionnalPoints { get; set; }
		public UInt16 SpellsPoints { get; set; }
		public ActorExtendedAlignmentInformations AlignmentInfos { get; set; }
		public UInt32 LifePoints { get; set; }
		public UInt32 MaxLifePoints { get; set; }
		public UInt16 EnergyPoints { get; set; }
		public UInt16 MaxEnergyPoints { get; set; }
		public Int16 ActionPointsCurrent { get; set; }
		public Int16 MovementPointsCurrent { get; set; }
		public CharacterBaseCharacteristic Initiative { get; set; }
		public CharacterBaseCharacteristic Prospecting { get; set; }
		public CharacterBaseCharacteristic ActionPoints { get; set; }
		public CharacterBaseCharacteristic MovementPoints { get; set; }
		public CharacterBaseCharacteristic Strength { get; set; }
		public CharacterBaseCharacteristic Vitality { get; set; }
		public CharacterBaseCharacteristic Wisdom { get; set; }
		public CharacterBaseCharacteristic Chance { get; set; }
		public CharacterBaseCharacteristic Agility { get; set; }
		public CharacterBaseCharacteristic Intelligence { get; set; }
		public CharacterBaseCharacteristic Range { get; set; }
		public CharacterBaseCharacteristic SummonableCreaturesBoost { get; set; }
		public CharacterBaseCharacteristic Reflect { get; set; }
		public CharacterBaseCharacteristic CriticalHit { get; set; }
		public UInt16 CriticalHitWeapon { get; set; }
		public CharacterBaseCharacteristic CriticalMiss { get; set; }
		public CharacterBaseCharacteristic HealBonus { get; set; }
		public CharacterBaseCharacteristic AllDamagesBonus { get; set; }
		public CharacterBaseCharacteristic WeaponDamagesBonusPercent { get; set; }
		public CharacterBaseCharacteristic DamagesBonusPercent { get; set; }
		public CharacterBaseCharacteristic TrapBonus { get; set; }
		public CharacterBaseCharacteristic TrapBonusPercent { get; set; }
		public CharacterBaseCharacteristic GlyphBonusPercent { get; set; }
		public CharacterBaseCharacteristic RuneBonusPercent { get; set; }
		public CharacterBaseCharacteristic PermanentDamagePercent { get; set; }
		public CharacterBaseCharacteristic TackleBlock { get; set; }
		public CharacterBaseCharacteristic TackleEvade { get; set; }
		public CharacterBaseCharacteristic PAAttack { get; set; }
		public CharacterBaseCharacteristic PMAttack { get; set; }
		public CharacterBaseCharacteristic PushDamageBonus { get; set; }
		public CharacterBaseCharacteristic CriticalDamageBonus { get; set; }
		public CharacterBaseCharacteristic NeutralDamageBonus { get; set; }
		public CharacterBaseCharacteristic EarthDamageBonus { get; set; }
		public CharacterBaseCharacteristic WaterDamageBonus { get; set; }
		public CharacterBaseCharacteristic AirDamageBonus { get; set; }
		public CharacterBaseCharacteristic FireDamageBonus { get; set; }
		public CharacterBaseCharacteristic DodgePALostProbability { get; set; }
		public CharacterBaseCharacteristic DodgePMLostProbability { get; set; }
		public CharacterBaseCharacteristic NeutralElementResistPercent { get; set; }
		public CharacterBaseCharacteristic EarthElementResistPercent { get; set; }
		public CharacterBaseCharacteristic WaterElementResistPercent { get; set; }
		public CharacterBaseCharacteristic AirElementResistPercent { get; set; }
		public CharacterBaseCharacteristic FireElementResistPercent { get; set; }
		public CharacterBaseCharacteristic NeutralElementReduction { get; set; }
		public CharacterBaseCharacteristic EarthElementReduction { get; set; }
		public CharacterBaseCharacteristic WaterElementReduction { get; set; }
		public CharacterBaseCharacteristic AirElementReduction { get; set; }
		public CharacterBaseCharacteristic FireElementReduction { get; set; }
		public CharacterBaseCharacteristic PushDamageReduction { get; set; }
		public CharacterBaseCharacteristic CriticalDamageReduction { get; set; }
		public CharacterBaseCharacteristic PvpNeutralElementResistPercent { get; set; }
		public CharacterBaseCharacteristic PvpEarthElementResistPercent { get; set; }
		public CharacterBaseCharacteristic PvpWaterElementResistPercent { get; set; }
		public CharacterBaseCharacteristic PvpAirElementResistPercent { get; set; }
		public CharacterBaseCharacteristic PvpFireElementResistPercent { get; set; }
		public CharacterBaseCharacteristic PvpNeutralElementReduction { get; set; }
		public CharacterBaseCharacteristic PvpEarthElementReduction { get; set; }
		public CharacterBaseCharacteristic PvpWaterElementReduction { get; set; }
		public CharacterBaseCharacteristic PvpAirElementReduction { get; set; }
		public CharacterBaseCharacteristic PvpFireElementReduction { get; set; }
		public CharacterBaseCharacteristic MeleeDamageDonePercent { get; set; }
		public CharacterBaseCharacteristic MeleeDamageReceivedPercent { get; set; }
		public CharacterBaseCharacteristic RangedDamageDonePercent { get; set; }
		public CharacterBaseCharacteristic RangedDamageReceivedPercent { get; set; }
		public CharacterBaseCharacteristic WeaponDamageDonePercent { get; set; }
		public CharacterBaseCharacteristic WeaponDamageReceivedPercent { get; set; }
		public CharacterBaseCharacteristic SpellDamageDonePercent { get; set; }
		public CharacterBaseCharacteristic SpellDamageReceivedPercent { get; set; }
		public CharacterSpellModification[] SpellModifications { get; set; }
		public UInt32 ProbationTime { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(Experience);
			writer.WriteVarLong(ExperienceLevelFloor);
			writer.WriteVarLong(ExperienceNextLevelFloor);
			writer.WriteVarLong(ExperienceBonusLimit);
			writer.WriteVarLong(Kamas);
			writer.WriteVarShort((Int16)StatsPoints);
			writer.WriteVarShort((Int16)AdditionnalPoints);
			writer.WriteVarShort((Int16)SpellsPoints);
			AlignmentInfos.Serialize(writer);
			writer.WriteVarInt((Int32)LifePoints);
			writer.WriteVarInt((Int32)MaxLifePoints);
			writer.WriteVarShort((Int16)EnergyPoints);
			writer.WriteVarShort((Int16)MaxEnergyPoints);
			writer.WriteVarShort(ActionPointsCurrent);
			writer.WriteVarShort(MovementPointsCurrent);
			Initiative.Serialize(writer);
			Prospecting.Serialize(writer);
			ActionPoints.Serialize(writer);
			MovementPoints.Serialize(writer);
			Strength.Serialize(writer);
			Vitality.Serialize(writer);
			Wisdom.Serialize(writer);
			Chance.Serialize(writer);
			Agility.Serialize(writer);
			Intelligence.Serialize(writer);
			Range.Serialize(writer);
			SummonableCreaturesBoost.Serialize(writer);
			Reflect.Serialize(writer);
			CriticalHit.Serialize(writer);
			writer.WriteVarShort((Int16)CriticalHitWeapon);
			CriticalMiss.Serialize(writer);
			HealBonus.Serialize(writer);
			AllDamagesBonus.Serialize(writer);
			WeaponDamagesBonusPercent.Serialize(writer);
			DamagesBonusPercent.Serialize(writer);
			TrapBonus.Serialize(writer);
			TrapBonusPercent.Serialize(writer);
			GlyphBonusPercent.Serialize(writer);
			RuneBonusPercent.Serialize(writer);
			PermanentDamagePercent.Serialize(writer);
			TackleBlock.Serialize(writer);
			TackleEvade.Serialize(writer);
			PAAttack.Serialize(writer);
			PMAttack.Serialize(writer);
			PushDamageBonus.Serialize(writer);
			CriticalDamageBonus.Serialize(writer);
			NeutralDamageBonus.Serialize(writer);
			EarthDamageBonus.Serialize(writer);
			WaterDamageBonus.Serialize(writer);
			AirDamageBonus.Serialize(writer);
			FireDamageBonus.Serialize(writer);
			DodgePALostProbability.Serialize(writer);
			DodgePMLostProbability.Serialize(writer);
			NeutralElementResistPercent.Serialize(writer);
			EarthElementResistPercent.Serialize(writer);
			WaterElementResistPercent.Serialize(writer);
			AirElementResistPercent.Serialize(writer);
			FireElementResistPercent.Serialize(writer);
			NeutralElementReduction.Serialize(writer);
			EarthElementReduction.Serialize(writer);
			WaterElementReduction.Serialize(writer);
			AirElementReduction.Serialize(writer);
			FireElementReduction.Serialize(writer);
			PushDamageReduction.Serialize(writer);
			CriticalDamageReduction.Serialize(writer);
			PvpNeutralElementResistPercent.Serialize(writer);
			PvpEarthElementResistPercent.Serialize(writer);
			PvpWaterElementResistPercent.Serialize(writer);
			PvpAirElementResistPercent.Serialize(writer);
			PvpFireElementResistPercent.Serialize(writer);
			PvpNeutralElementReduction.Serialize(writer);
			PvpEarthElementReduction.Serialize(writer);
			PvpWaterElementReduction.Serialize(writer);
			PvpAirElementReduction.Serialize(writer);
			PvpFireElementReduction.Serialize(writer);
			MeleeDamageDonePercent.Serialize(writer);
			MeleeDamageReceivedPercent.Serialize(writer);
			RangedDamageDonePercent.Serialize(writer);
			RangedDamageReceivedPercent.Serialize(writer);
			WeaponDamageDonePercent.Serialize(writer);
			WeaponDamageReceivedPercent.Serialize(writer);
			SpellDamageDonePercent.Serialize(writer);
			SpellDamageReceivedPercent.Serialize(writer);
			for (var i = 0; i < SpellModifications.Length; i++)
			{
				SpellModifications[i].Serialize(writer);
			}
			writer.WriteInt((Int32)ProbationTime);
		}
		public void Deserialize(IDataReader reader)
		{
			Experience = reader.ReadVarLong();
			ExperienceLevelFloor = reader.ReadVarLong();
			ExperienceNextLevelFloor = reader.ReadVarLong();
			ExperienceBonusLimit = reader.ReadVarLong();
			Kamas = reader.ReadVarLong();
			StatsPoints = (UInt16)reader.ReadVarShort();
			AdditionnalPoints = (UInt16)reader.ReadVarShort();
			SpellsPoints = (UInt16)reader.ReadVarShort();
			AlignmentInfos = new ActorExtendedAlignmentInformations();
			AlignmentInfos.Deserialize(reader);
			LifePoints = (UInt32)reader.ReadVarInt();
			MaxLifePoints = (UInt32)reader.ReadVarInt();
			EnergyPoints = (UInt16)reader.ReadVarShort();
			MaxEnergyPoints = (UInt16)reader.ReadVarShort();
			ActionPointsCurrent = reader.ReadVarShort();
			MovementPointsCurrent = reader.ReadVarShort();
			Initiative = new CharacterBaseCharacteristic();
			Initiative.Deserialize(reader);
			Prospecting = new CharacterBaseCharacteristic();
			Prospecting.Deserialize(reader);
			ActionPoints = new CharacterBaseCharacteristic();
			ActionPoints.Deserialize(reader);
			MovementPoints = new CharacterBaseCharacteristic();
			MovementPoints.Deserialize(reader);
			Strength = new CharacterBaseCharacteristic();
			Strength.Deserialize(reader);
			Vitality = new CharacterBaseCharacteristic();
			Vitality.Deserialize(reader);
			Wisdom = new CharacterBaseCharacteristic();
			Wisdom.Deserialize(reader);
			Chance = new CharacterBaseCharacteristic();
			Chance.Deserialize(reader);
			Agility = new CharacterBaseCharacteristic();
			Agility.Deserialize(reader);
			Intelligence = new CharacterBaseCharacteristic();
			Intelligence.Deserialize(reader);
			Range = new CharacterBaseCharacteristic();
			Range.Deserialize(reader);
			SummonableCreaturesBoost = new CharacterBaseCharacteristic();
			SummonableCreaturesBoost.Deserialize(reader);
			Reflect = new CharacterBaseCharacteristic();
			Reflect.Deserialize(reader);
			CriticalHit = new CharacterBaseCharacteristic();
			CriticalHit.Deserialize(reader);
			CriticalHitWeapon = (UInt16)reader.ReadVarShort();
			CriticalMiss = new CharacterBaseCharacteristic();
			CriticalMiss.Deserialize(reader);
			HealBonus = new CharacterBaseCharacteristic();
			HealBonus.Deserialize(reader);
			AllDamagesBonus = new CharacterBaseCharacteristic();
			AllDamagesBonus.Deserialize(reader);
			WeaponDamagesBonusPercent = new CharacterBaseCharacteristic();
			WeaponDamagesBonusPercent.Deserialize(reader);
			DamagesBonusPercent = new CharacterBaseCharacteristic();
			DamagesBonusPercent.Deserialize(reader);
			TrapBonus = new CharacterBaseCharacteristic();
			TrapBonus.Deserialize(reader);
			TrapBonusPercent = new CharacterBaseCharacteristic();
			TrapBonusPercent.Deserialize(reader);
			GlyphBonusPercent = new CharacterBaseCharacteristic();
			GlyphBonusPercent.Deserialize(reader);
			RuneBonusPercent = new CharacterBaseCharacteristic();
			RuneBonusPercent.Deserialize(reader);
			PermanentDamagePercent = new CharacterBaseCharacteristic();
			PermanentDamagePercent.Deserialize(reader);
			TackleBlock = new CharacterBaseCharacteristic();
			TackleBlock.Deserialize(reader);
			TackleEvade = new CharacterBaseCharacteristic();
			TackleEvade.Deserialize(reader);
			PAAttack = new CharacterBaseCharacteristic();
			PAAttack.Deserialize(reader);
			PMAttack = new CharacterBaseCharacteristic();
			PMAttack.Deserialize(reader);
			PushDamageBonus = new CharacterBaseCharacteristic();
			PushDamageBonus.Deserialize(reader);
			CriticalDamageBonus = new CharacterBaseCharacteristic();
			CriticalDamageBonus.Deserialize(reader);
			NeutralDamageBonus = new CharacterBaseCharacteristic();
			NeutralDamageBonus.Deserialize(reader);
			EarthDamageBonus = new CharacterBaseCharacteristic();
			EarthDamageBonus.Deserialize(reader);
			WaterDamageBonus = new CharacterBaseCharacteristic();
			WaterDamageBonus.Deserialize(reader);
			AirDamageBonus = new CharacterBaseCharacteristic();
			AirDamageBonus.Deserialize(reader);
			FireDamageBonus = new CharacterBaseCharacteristic();
			FireDamageBonus.Deserialize(reader);
			DodgePALostProbability = new CharacterBaseCharacteristic();
			DodgePALostProbability.Deserialize(reader);
			DodgePMLostProbability = new CharacterBaseCharacteristic();
			DodgePMLostProbability.Deserialize(reader);
			NeutralElementResistPercent = new CharacterBaseCharacteristic();
			NeutralElementResistPercent.Deserialize(reader);
			EarthElementResistPercent = new CharacterBaseCharacteristic();
			EarthElementResistPercent.Deserialize(reader);
			WaterElementResistPercent = new CharacterBaseCharacteristic();
			WaterElementResistPercent.Deserialize(reader);
			AirElementResistPercent = new CharacterBaseCharacteristic();
			AirElementResistPercent.Deserialize(reader);
			FireElementResistPercent = new CharacterBaseCharacteristic();
			FireElementResistPercent.Deserialize(reader);
			NeutralElementReduction = new CharacterBaseCharacteristic();
			NeutralElementReduction.Deserialize(reader);
			EarthElementReduction = new CharacterBaseCharacteristic();
			EarthElementReduction.Deserialize(reader);
			WaterElementReduction = new CharacterBaseCharacteristic();
			WaterElementReduction.Deserialize(reader);
			AirElementReduction = new CharacterBaseCharacteristic();
			AirElementReduction.Deserialize(reader);
			FireElementReduction = new CharacterBaseCharacteristic();
			FireElementReduction.Deserialize(reader);
			PushDamageReduction = new CharacterBaseCharacteristic();
			PushDamageReduction.Deserialize(reader);
			CriticalDamageReduction = new CharacterBaseCharacteristic();
			CriticalDamageReduction.Deserialize(reader);
			PvpNeutralElementResistPercent = new CharacterBaseCharacteristic();
			PvpNeutralElementResistPercent.Deserialize(reader);
			PvpEarthElementResistPercent = new CharacterBaseCharacteristic();
			PvpEarthElementResistPercent.Deserialize(reader);
			PvpWaterElementResistPercent = new CharacterBaseCharacteristic();
			PvpWaterElementResistPercent.Deserialize(reader);
			PvpAirElementResistPercent = new CharacterBaseCharacteristic();
			PvpAirElementResistPercent.Deserialize(reader);
			PvpFireElementResistPercent = new CharacterBaseCharacteristic();
			PvpFireElementResistPercent.Deserialize(reader);
			PvpNeutralElementReduction = new CharacterBaseCharacteristic();
			PvpNeutralElementReduction.Deserialize(reader);
			PvpEarthElementReduction = new CharacterBaseCharacteristic();
			PvpEarthElementReduction.Deserialize(reader);
			PvpWaterElementReduction = new CharacterBaseCharacteristic();
			PvpWaterElementReduction.Deserialize(reader);
			PvpAirElementReduction = new CharacterBaseCharacteristic();
			PvpAirElementReduction.Deserialize(reader);
			PvpFireElementReduction = new CharacterBaseCharacteristic();
			PvpFireElementReduction.Deserialize(reader);
			MeleeDamageDonePercent = new CharacterBaseCharacteristic();
			MeleeDamageDonePercent.Deserialize(reader);
			MeleeDamageReceivedPercent = new CharacterBaseCharacteristic();
			MeleeDamageReceivedPercent.Deserialize(reader);
			RangedDamageDonePercent = new CharacterBaseCharacteristic();
			RangedDamageDonePercent.Deserialize(reader);
			RangedDamageReceivedPercent = new CharacterBaseCharacteristic();
			RangedDamageReceivedPercent.Deserialize(reader);
			WeaponDamageDonePercent = new CharacterBaseCharacteristic();
			WeaponDamageDonePercent.Deserialize(reader);
			WeaponDamageReceivedPercent = new CharacterBaseCharacteristic();
			WeaponDamageReceivedPercent.Deserialize(reader);
			SpellDamageDonePercent = new CharacterBaseCharacteristic();
			SpellDamageDonePercent.Deserialize(reader);
			SpellDamageReceivedPercent = new CharacterBaseCharacteristic();
			SpellDamageReceivedPercent.Deserialize(reader);
			SpellModifications = new CharacterSpellModification[reader.ReadShort()];
			for (var i = 0; i < SpellModifications.Length; i++)
			{
				(SpellModifications[i] = new CharacterSpellModification()).Deserialize(reader);
			}
			ProbationTime = (UInt32)reader.ReadInt();
		}
	}
}
