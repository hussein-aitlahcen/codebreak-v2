using System;
using CodebreakV2.Protocol.Types;
namespace CodebreakV2.Protocol.Messages
{
	public class CharacterDeletionRequestMessage
	{
		public Int64 CharacterId { get; set; }
		public String SecretAnswerHash { get; set; }
		public void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(CharacterId);
			writer.WriteUTF(SecretAnswerHash);
		}
		public void Deserialize(IDataReader reader)
		{
			CharacterId = reader.ReadVarLong();
			SecretAnswerHash = reader.ReadUTF();
		}
	}
}
