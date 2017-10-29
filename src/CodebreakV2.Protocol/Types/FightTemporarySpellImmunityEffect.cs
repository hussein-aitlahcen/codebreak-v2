using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTemporarySpellImmunityEffect : AbstractFightDispellableEffect
	{
		public Int32 ImmuneSpellId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(ImmuneSpellId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ImmuneSpellId = reader.ReadInt();
		}
	}
}
