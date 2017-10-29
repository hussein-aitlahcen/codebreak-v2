using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class ArenaFighterLeaveMessage
	{
		public CharacterBasicMinimalInformations Leaver { get; set; }
		public void Serialize(IDataWriter writer)
		{
			Leaver.Serialize(writer);
		}
		public void Deserialize(IDataReader reader)
		{
			Leaver = new CharacterBasicMinimalInformations();
			Leaver.Deserialize(reader);
		}
	}
}
