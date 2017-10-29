using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class PrismFightAttackerAddMessage
	{
		public UInt16 SubAreaId { get; set; }
		public UInt16 FightId { get; set; }
		public CharacterMinimalPlusLookInformations Attacker { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((Int16)SubAreaId);
			writer.WriteVarShort((Int16)FightId);
			Attacker.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			SubAreaId = (UInt16)reader.ReadVarShort();
			FightId = (UInt16)reader.ReadVarShort();
			Attacker = new CharacterMinimalPlusLookInformations();
			Attacker.Deserialize(reader);
		}
	}
}
