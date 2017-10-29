using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismFightDefenderAddMessage
	{
		public UInt16 SubAreaId { get; set; }
		public UInt16 FightId { get; set; }
		public CharacterMinimalPlusLookInformations Defender { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteVarShort((Int16)FightId);
			Defender.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			SubAreaId = (UInt16)reader.ReadVarShort();
			FightId = (UInt16)reader.ReadVarShort();
			Defender = new CharacterMinimalPlusLookInformations();
			Defender.Deserialize(reader);
		}
	}
}
