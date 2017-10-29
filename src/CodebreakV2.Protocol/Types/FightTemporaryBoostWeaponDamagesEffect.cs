using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTemporaryBoostWeaponDamagesEffect : FightTemporaryBoostEffect
	{
		public Int16 WeaponTypeId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(WeaponTypeId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			WeaponTypeId = reader.ReadShort();
		}
	}
}
