using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightDispellableEffectExtendedInformations
	{
		public UInt16 ActionId { get; set; }
		public Double SourceId { get; set; }
		public AbstractFightDispellableEffect Effect { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)ActionId);
			writer.WriteDouble(SourceId);
			Effect.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			ActionId = (UInt16)reader.ReadVarShort();
			SourceId = reader.ReadDouble();
			Effect = new AbstractFightDispellableEffect();
			Effect.Deserialize(reader);
		}
	}
}
