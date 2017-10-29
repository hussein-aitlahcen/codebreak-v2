using System;
namespace CodebreakV2.Protocol.Types
{
	public class FightResultFighterListEntry : FightResultListEntry
	{
		public Double Id { get; set; }
		public Boolean Alive { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(Id);
			writer.WriteBoolean(Alive);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			Id = reader.ReadDouble();
			Alive = reader.ReadBoolean();
		}
	}
}
