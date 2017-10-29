using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTemporaryBoostStateEffect : FightTemporaryBoostEffect
	{
		public Int16 StateId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(StateId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			StateId = reader.ReadShort();
		}
	}
}
