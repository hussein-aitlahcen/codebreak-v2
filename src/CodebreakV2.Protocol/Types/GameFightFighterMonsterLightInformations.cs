using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameFightFighterMonsterLightInformations : GameFightFighterLightInformations
	{
		public UInt16 CreatureGenericId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)CreatureGenericId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CreatureGenericId = (UInt16)reader.ReadVarShort();
		}
	}
}
