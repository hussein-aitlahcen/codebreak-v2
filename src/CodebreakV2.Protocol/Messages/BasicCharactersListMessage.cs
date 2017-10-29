using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class BasicCharactersListMessage
	{
		public CharacterBaseInformations[] Characters { get; set; }
		public void Serialize(IDataWriter writer)
		{
			for (var i = 0; i < Characters.Length; i++)
			{
				Characters[i].Serialize(writer);
			}
		}
		public void Deserialize(IDataReader reader)
		{
			Characters = new CharacterBaseInformations[reader.ReadShort()];
			for (var i = 0; i < Characters.Length; i++)
			{
				(Characters[i] = new CharacterBaseInformations()).Deserialize(reader);
			}
		}
	}
}
