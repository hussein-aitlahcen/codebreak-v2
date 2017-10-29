using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightTemporaryBoostEffect : AbstractFightDispellableEffect
	{
		public Int16 Delta { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(Delta);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Delta = reader.ReadShort();
		}
	}
}
