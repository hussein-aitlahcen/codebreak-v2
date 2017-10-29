using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayTreasureHintInformations : GameRolePlayActorInformations
	{
		public UInt16 NpcId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)NpcId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			NpcId = (UInt16)reader.ReadVarShort();
		}
	}
}
