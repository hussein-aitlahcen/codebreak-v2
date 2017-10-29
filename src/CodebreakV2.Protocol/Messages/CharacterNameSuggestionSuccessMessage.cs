using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterNameSuggestionSuccessMessage
	{
		public String Suggestion { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(Suggestion);
		}
		public void Deserialize(IDataReader reader)
		{
			Suggestion = reader.ReadUTF();
		}
	}
}
