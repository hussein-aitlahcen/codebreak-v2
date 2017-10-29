using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharactersListWithRemodelingMessage : CharactersListMessage
	{
		public CharacterToRemodelInformations[] CharactersToRemodel { get; set; }
		public new void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			for (var i = 0; i < CharactersToRemodel.Length; i++)
			{
				CharactersToRemodel[i].Serialize(writer);
			}
		}
		public new void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			CharactersToRemodel = new CharacterToRemodelInformations[reader.ReadShort()];
			for (var i = 0; i < CharactersToRemodel.Length; i++)
			{
				(CharactersToRemodel[i] = new CharacterToRemodelInformations()).Deserialize(reader);
			}
		}
	}
}
