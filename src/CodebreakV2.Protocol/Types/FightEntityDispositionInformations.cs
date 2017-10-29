using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightEntityDispositionInformations : EntityDispositionInformations
	{
		public Double CarryingCharacterId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(CarryingCharacterId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CarryingCharacterId = reader.ReadDouble();
		}
	}
}
