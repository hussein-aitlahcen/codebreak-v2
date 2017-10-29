using System;
namespace CodebreakV2.Protocol.Types
{
	public class GameRolePlayNpcInformations : GameRolePlayActorInformations
	{
		public UInt16 NpcId { get; set; }
		public Boolean Sex { get; set; }
		public UInt16 SpecialArtworkId { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((Int16)NpcId);
			writer.WriteBoolean(Sex);
			writer.WriteVarShort((Int16)SpecialArtworkId);
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			NpcId = (UInt16)reader.ReadVarShort();
			Sex = reader.ReadBoolean();
			SpecialArtworkId = (UInt16)reader.ReadVarShort();
		}
	}
}
