using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class GameActionFightCloseCombatMessage : AbstractGameActionFightTargetedAbilityMessage
	{
		public UInt16 WeaponGenericId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)WeaponGenericId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			WeaponGenericId = (UInt16)reader.ReadVarShort();
		}
	}
}
